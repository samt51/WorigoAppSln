using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QRCoder;
using System.Globalization;
using System.Security.Cryptography;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;
using WorigoApp.Persistence.Context;

namespace WorigoApp.Api.Controllers.Reception
{
    [ApiController]
    [Authorize(Roles = "SystemAdmin,HotelAdmin,Management,DepartmentManager,Employee")]
    [Route("api/reception")]
    public class ReceptionMobileAccessController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ReceptionMobileAccessController(AppDbContext dbContext, IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        [HttpPost("mobile-check-in")]
        public async Task<ResponseDto<ReceptionMobileCheckInResponse>> PrepareMobileCheckIn(
            [FromBody] ReceptionMobileCheckInRequest request,
            CancellationToken cancellationToken)
        {
            var hotelId = request.HotelId <= 0 ? 1 : request.HotelId;
            var roomName = string.IsNullOrWhiteSpace(request.RoomName) ? "101" : request.RoomName.Trim();
            var customerName = string.IsNullOrWhiteSpace(request.CustomerName) ? "Mobil" : request.CustomerName.Trim();
            var customerSurname = string.IsNullOrWhiteSpace(request.CustomerSurname) ? "Misafir" : request.CustomerSurname.Trim();
            var languageCode = string.IsNullOrWhiteSpace(request.LanguageCode) ? "tr-TR" : request.LanguageCode.Trim();
            var currencyCode = string.IsNullOrWhiteSpace(request.CurrencyCode) ? "TRY" : request.CurrencyCode.Trim().ToUpperInvariant();
            var checkInDate = (request.CheckInDate ?? DateTime.Today).Date;
            var checkOutDate = (request.CheckOutDate ?? checkInDate.AddDays(Math.Max(1, request.StayDays))).Date;

            if (checkOutDate <= checkInDate)
            {
                checkOutDate = checkInDate.AddDays(1);
            }

            var room = await _dbContext.Set<Room>()
                .Include(x => x.Hotel)
                .FirstOrDefaultAsync(x =>
                    x.HotelId == hotelId &&
                    !x.IsDeleted &&
                    (x.Name == roomName || x.RoomNumber == roomName),
                    cancellationToken);

            if (room is null)
            {
                return new ResponseDto<ReceptionMobileCheckInResponse>()
                    .Fail($"Oda bulunamadi. HotelId={hotelId}, Oda={roomName}", 404);
            }

            var currencyExists = await _dbContext.Set<Currency>()
                .AsNoTracking()
                .AnyAsync(x => x.Code == currencyCode && x.IsSupported && x.IsActive && !x.IsDeleted, cancellationToken);

            if (!currencyExists)
            {
                return new ResponseDto<ReceptionMobileCheckInResponse>().Fail("Desteklenmeyen para birimi.", 400);
            }

            var stayDays = Math.Max(1, (checkOutDate - checkInDate).Days);
            var basePrice = request.Price.HasValue && request.Price.Value > 0
                ? request.Price.Value
                : room.Price * stayDays;
            var conversion = await ConvertCurrencyAsync(basePrice, "TRY", currencyCode, cancellationToken);

            if (!conversion.IsSuccess)
            {
                return new ResponseDto<ReceptionMobileCheckInResponse>().Fail(conversion.ErrorMessage, 502);
            }

            var strategy = _dbContext.Database.CreateExecutionStrategy();
            return await strategy.ExecuteAsync(async () =>
            {
                await using var transaction = await _dbContext.Database.BeginTransactionAsync(cancellationToken);

                var trackingRoom = await _dbContext.Set<Room>()
                    .Include(x => x.Hotel)
                    .FirstOrDefaultAsync(x => x.Id == room.Id, cancellationToken);

                if (trackingRoom == null)
                {
                    return new ResponseDto<ReceptionMobileCheckInResponse>().Fail($"Oda bulunamadi. HotelId={hotelId}, Oda={roomName}", 404);
                }

                var guestStay = await _dbContext.Set<GuestStay>()
                    .Include(x => x.Customers)
                    .Where(x =>
                        x.HotelId == hotelId &&
                        x.RoomId == trackingRoom.Id &&
                        x.IsActive &&
                        !x.IsDeleted &&
                        x.ActualCheckOutAt == null &&
                        x.CheckOutDate.Date >= DateTime.Today)
                    .OrderByDescending(x => x.Id)
                    .FirstOrDefaultAsync(cancellationToken);

                if (guestStay is null)
                {
                    guestStay = new GuestStay
                    {
                        HotelId = hotelId,
                        RoomId = trackingRoom.Id,
                        CheckInDate = checkInDate,
                        CheckOutDate = checkOutDate,
                        ActualCheckInAt = DateTime.UtcNow,
                        VerificationCode = CreateVerificationCode(),
                        GuestLanguageCode = languageCode,
                        IsMobileAccessEnabled = true,
                        Status = "Active",
                        AccommodationConceptType = ResolveConcept(request.AccommodationConceptType),
                        CurrencyCode = currencyCode,
                        TotalPrice = conversion.ConvertedAmount
                    };

                    await _dbContext.Set<GuestStay>().AddAsync(guestStay, cancellationToken);
                    await _dbContext.SaveChangesAsync(cancellationToken);
                }
                else
                {
                    guestStay.CheckInDate = checkInDate;
                    guestStay.CheckOutDate = checkOutDate;
                    guestStay.GuestLanguageCode = languageCode;
                    guestStay.IsMobileAccessEnabled = true;
                    guestStay.Status = "Active";
                    guestStay.CurrencyCode = currencyCode;
                    guestStay.TotalPrice = conversion.ConvertedAmount;
                    guestStay.ModifyDate = DateTime.Now;
                }

                var customer = guestStay.Customers
                    .FirstOrDefault(x =>
                        !x.IsDeleted &&
                        x.Name == customerName &&
                        x.SurName == customerSurname);

                if (customer is null)
                {
                    customer = new Customer
                    {
                        GuestStayId = guestStay.Id,
                        Name = customerName,
                        SurName = customerSurname,
                        PreferredLanguageCode = languageCode,
                        IsPrimaryGuest = !guestStay.PrimaryCustomerId.HasValue
                    };

                    await _dbContext.Set<Customer>().AddAsync(customer, cancellationToken);
                    await _dbContext.SaveChangesAsync(cancellationToken);
                }

                if (!guestStay.PrimaryCustomerId.HasValue)
                {
                    guestStay.PrimaryCustomerId = customer.Id;
                }

                trackingRoom.IsFull = true;
                trackingRoom.CurrentStatus = "Occupied";
                trackingRoom.ModifyDate = DateTime.Now;

                var qrCodeToken = CreateToken("qr");
                var session = new GuestSession
                {
                    GuestStayId = guestStay.Id,
                    CustomerId = customer.Id,
                    SessionToken = CreateToken("session"),
                    QrCodeToken = qrCodeToken,
                    ExpiresAt = DateTime.UtcNow.AddDays(7),
                    LanguageCode = languageCode,
                    IsActiveSession = true
                };

                await _dbContext.Set<GuestSession>().AddAsync(session, cancellationToken);
                await _dbContext.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);

                var mobileLoginUrl = BuildMobileLoginUrl(qrCodeToken);

                return new ResponseDto<ReceptionMobileCheckInResponse>().Success(new ReceptionMobileCheckInResponse
                {
                    HotelId = hotelId,
                    HotelName = trackingRoom.Hotel?.Name ?? string.Empty,
                    RoomId = trackingRoom.Id,
                    RoomName = trackingRoom.Name,
                    GuestStayId = guestStay.Id,
                    CustomerId = customer.Id,
                    GuestSessionId = session.Id,
                    GuestName = $"{customer.Name} {customer.SurName}".Trim(),
                    VerificationCode = guestStay.VerificationCode,
                    SessionToken = session.SessionToken,
                    QrCodeToken = qrCodeToken,
                    MobileLoginUrl = mobileLoginUrl,
                    QrImageUrl = Url.ActionLink(nameof(GetMobileCheckInQr), values: new { qrCodeToken }) ?? $"/api/reception/mobile-check-in/qr.png?qrCodeToken={Uri.EscapeDataString(qrCodeToken)}",
                    LanguageCode = languageCode,
                    CheckInDate = guestStay.CheckInDate,
                    CheckOutDate = guestStay.CheckOutDate,
                    ExpiresAt = session.ExpiresAt,
                    BasePrice = basePrice,
                    TotalPrice = conversion.ConvertedAmount,
                    CurrencyCode = currencyCode,
                    ExchangeRate = conversion.Rate,
                    ExchangeRateDate = conversion.RateDate,
                    IsVip = guestStay.IsVip,
                    HasAllergy = guestStay.HasAllergy,
                    DoNotDisturb = guestStay.DoNotDisturb,
                    IsLateCheckOut = guestStay.IsLateCheckOut
                });
            });
        }

        [HttpGet("mobile-check-in/by-room")]
        public async Task<ResponseDto<ReceptionMobileCheckInResponse>> GetActiveMobileCheckInByRoom(
            [FromQuery] int hotelId,
            [FromQuery] int roomId,
            CancellationToken cancellationToken)
        {
            hotelId = hotelId <= 0 ? 1 : hotelId;
            var today = DateTime.Today;

            var guestStay = await _dbContext.Set<GuestStay>()
                .AsNoTracking()
                .Include(x => x.Room)
                    .ThenInclude(x => x.Hotel)
                .Include(x => x.Customers)
                .Include(x => x.GuestSessions)
                .Where(x =>
                    x.HotelId == hotelId &&
                    x.RoomId == roomId &&
                    x.IsActive &&
                    !x.IsDeleted &&
                    x.ActualCheckOutAt == null &&
                    x.CheckOutDate.Date >= today)
                .OrderByDescending(x => x.Id)
                .FirstOrDefaultAsync(cancellationToken);

            if (guestStay is null)
            {
                return new ResponseDto<ReceptionMobileCheckInResponse>()
                    .Fail("Bu oda icin aktif konaklama bulunamadi.", 404);
            }

            var customer = guestStay.PrimaryCustomerId.HasValue
                ? guestStay.Customers.FirstOrDefault(x => x.Id == guestStay.PrimaryCustomerId.Value && !x.IsDeleted)
                : null;

            customer ??= guestStay.Customers
                .Where(x => !x.IsDeleted)
                .OrderByDescending(x => x.IsPrimaryGuest)
                .ThenByDescending(x => x.Id)
                .FirstOrDefault();

            var session = guestStay.GuestSessions
                .Where(x =>
                    !x.IsDeleted &&
                    x.IsActiveSession &&
                    x.ExpiresAt > DateTime.UtcNow)
                .OrderByDescending(x => x.Id)
                .FirstOrDefault();

            var qrCodeToken = session?.QrCodeToken ?? string.Empty;
            var mobileLoginUrl = string.IsNullOrWhiteSpace(qrCodeToken)
                ? string.Empty
                : BuildMobileLoginUrl(qrCodeToken);

            return new ResponseDto<ReceptionMobileCheckInResponse>().Success(new ReceptionMobileCheckInResponse
            {
                HotelId = guestStay.HotelId,
                HotelName = guestStay.Room?.Hotel?.Name ?? string.Empty,
                RoomId = guestStay.RoomId,
                RoomName = guestStay.Room?.Name ?? guestStay.RoomId.ToString(CultureInfo.InvariantCulture),
                GuestStayId = guestStay.Id,
                CustomerId = customer?.Id ?? 0,
                GuestSessionId = session?.Id ?? 0,
                GuestName = customer is null ? "-" : $"{customer.Name} {customer.SurName}".Trim(),
                VerificationCode = guestStay.VerificationCode,
                SessionToken = session?.SessionToken ?? string.Empty,
                QrCodeToken = qrCodeToken,
                MobileLoginUrl = mobileLoginUrl,
                QrImageUrl = string.IsNullOrWhiteSpace(qrCodeToken)
                    ? string.Empty
                    : Url.ActionLink(nameof(GetMobileCheckInQr), values: new { qrCodeToken }) ?? $"/api/reception/mobile-check-in/qr.png?qrCodeToken={Uri.EscapeDataString(qrCodeToken)}",
                LanguageCode = session?.LanguageCode ?? guestStay.GuestLanguageCode,
                CheckInDate = guestStay.CheckInDate,
                CheckOutDate = guestStay.CheckOutDate,
                ExpiresAt = session?.ExpiresAt ?? DateTime.MinValue,
                BasePrice = guestStay.TotalPrice,
                TotalPrice = guestStay.TotalPrice,
                CurrencyCode = guestStay.CurrencyCode,
                ExchangeRate = 1,
                ExchangeRateDate = DateTime.UtcNow.Date,
                IsVip = guestStay.IsVip,
                HasAllergy = guestStay.HasAllergy,
                DoNotDisturb = guestStay.DoNotDisturb,
                IsLateCheckOut = guestStay.IsLateCheckOut
            });
        }

        [AllowAnonymous]
        [HttpGet("mobile-check-in/qr.png")]
        [Produces("image/png")]
        public async Task<IActionResult> GetMobileCheckInQr([FromQuery] string qrCodeToken, [FromQuery] string? guestAppUrl, CancellationToken cancellationToken)
        {
            qrCodeToken = qrCodeToken?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(qrCodeToken))
            {
                return BadRequest(new ResponseDto<string>().Fail("QR token zorunludur.", 400));
            }

            var session = await _dbContext.Set<GuestSession>()
                .AsNoTracking()
                .FirstOrDefaultAsync(x =>
                    x.IsActiveSession &&
                    !x.IsDeleted &&
                    x.ExpiresAt > DateTime.UtcNow &&
                    x.QrCodeToken == qrCodeToken,
                    cancellationToken);

            if (session is null)
            {
                return NotFound(new ResponseDto<string>().Fail("QR oturumu bulunamadi veya suresi doldu.", 404));
            }

            var mobileLoginUrl = BuildMobileLoginUrl(qrCodeToken, guestAppUrl);
            using var qrGenerator = new QRCodeGenerator();
            using var qrData = qrGenerator.CreateQrCode(mobileLoginUrl, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new PngByteQRCode(qrData);
            var qrBytes = qrCode.GetGraphic(12);

            Response.Headers.CacheControl = "no-store, no-cache, max-age=0";
            return File(qrBytes, "image/png");
        }

        private static AccommodationConceptTypeEnum ResolveConcept(int concept)
        {
            return Enum.IsDefined(typeof(AccommodationConceptTypeEnum), concept)
                ? (AccommodationConceptTypeEnum)concept
                : AccommodationConceptTypeEnum.AllInclusive;
        }

        private static string CreateVerificationCode()
        {
            return RandomNumberGenerator.GetInt32(100000, 999999).ToString();
        }

        private static string CreateToken(string prefix)
        {
            var bytes = RandomNumberGenerator.GetBytes(32);
            return $"{prefix}_{Convert.ToBase64String(bytes).Replace("+", "-").Replace("/", "_").TrimEnd('=')}";
        }

        private string BuildMobileLoginUrl(string qrCodeToken, string? guestAppUrl = null)
        {
            var encodedToken = Uri.EscapeDataString(qrCodeToken);
            var baseUrl = !string.IsNullOrWhiteSpace(guestAppUrl) 
                ? guestAppUrl 
                : (_configuration["GuestAppUrl"] ?? $"{Request.Scheme}://{Request.Host}/mobile/guest/qr-login");
            return $"{baseUrl.TrimEnd('/')}?qrCodeToken={encodedToken}";
        }

        private async Task<CurrencyConversionResult> ConvertCurrencyAsync(decimal amount, string from, string to, CancellationToken cancellationToken)
        {
            from = from.Trim().ToUpperInvariant();
            to = to.Trim().ToUpperInvariant();

            if (from == to)
            {
                return CurrencyConversionResult.Success(amount, 1, DateTime.UtcNow.Date);
            }

            try
            {
                var url = $"https://open.er-api.com/v6/latest/{from}";
                using var client = _httpClientFactory.CreateClient();
                using var response = await client.GetAsync(url, cancellationToken);
                var content = await response.Content.ReadAsStringAsync(cancellationToken);

                if (!response.IsSuccessStatusCode)
                {
                    return CurrencyConversionResult.Fail("Kur servisine ulasilamadi.");
                }

                using var document = JsonDocument.Parse(content);
                var root = document.RootElement;
                var result = root.TryGetProperty("result", out var resultElement) ? resultElement.GetString() : string.Empty;

                if (!string.Equals(result, "success", StringComparison.OrdinalIgnoreCase) ||
                    !root.TryGetProperty("rates", out var ratesElement) ||
                    !ratesElement.TryGetProperty(to, out var rateElement))
                {
                    return CurrencyConversionResult.Fail("Kur bilgisi bulunamadi.");
                }

                var rate = rateElement.GetDecimal();
                var convertedAmount = decimal.Round(amount * rate, 2, MidpointRounding.AwayFromZero);
                var rateDate = root.TryGetProperty("time_last_update_utc", out var dateElement) &&
                               DateTime.TryParse(dateElement.GetString(), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out var parsedDate)
                    ? parsedDate.Date
                    : DateTime.UtcNow.Date;

                return CurrencyConversionResult.Success(convertedAmount, rate, rateDate);
            }
            catch
            {
                return CurrencyConversionResult.Fail("Kur cevrimi tamamlanamadi.");
            }
        }

        [HttpGet("rooms/{roomId:int}/folio")]
        public async Task<ResponseDto<ReceptionFolioResponse>> GetRoomFolio(
            int roomId,
            CancellationToken cancellationToken)
        {
            var guestStay = await _dbContext.Set<GuestStay>()
                .Include(x => x.Room)
                .Include(x => x.Customers)
                .Include(x => x.Orders)
                    .ThenInclude(x => x.OrderItems)
                .Include(x => x.Charges)
                .Where(x => x.RoomId == roomId && x.IsActive && !x.IsDeleted && x.ActualCheckOutAt == null)
                .OrderByDescending(x => x.Id)
                .FirstOrDefaultAsync(cancellationToken);

            if (guestStay is null)
            {
                return new ResponseDto<ReceptionFolioResponse>().Fail("Bu oda için aktif konaklama bulunamadı.", 404);
            }

            var stayDays = Math.Max(1, (guestStay.CheckOutDate.Date - guestStay.CheckInDate.Date).Days);
            
            var folioItems = new List<FolioItemDto>
            {
                new FolioItemDto
                {
                    Type = "Accommodation",
                    Description = $"Konaklama Bedeli ({stayDays} Gece)",
                    Amount = guestStay.TotalPrice,
                    CurrencyCode = guestStay.CurrencyCode,
                    Date = guestStay.CheckInDate,
                    IsPayment = false
                }
            };

            foreach (var order in guestStay.Orders.Where(o => o.PaymentOption == OrderPaymentOptionEnum.RoomCharge && !o.IsDeleted))
            {
                var itemNames = order.OrderItems.Select(oi => oi.Text);
                var itemsStr = itemNames.Any() ? " (" + string.Join(", ", itemNames) + ")" : "";
                folioItems.Add(new FolioItemDto
                {
                    Type = "Order",
                    Description = $"Sipariş #{order.OrderNumber}{itemsStr}",
                    Amount = order.TotalPrice,
                    CurrencyCode = order.CurrencyCode,
                    Date = order.CreatedDate,
                    IsPayment = false
                });
            }

            foreach (var charge in guestStay.Charges.Where(c => c.Amount > 0 && c.OrderId == null && !c.IsDeleted))
            {
                folioItems.Add(new FolioItemDto
                {
                    Type = "Charge",
                    Description = charge.Description,
                    Amount = charge.Amount,
                    CurrencyCode = charge.CurrencyCode,
                    Date = charge.CreatedDate,
                    IsPayment = false
                });
            }

            foreach (var charge in guestStay.Charges.Where(c => c.Amount < 0 && !c.IsDeleted))
            {
                folioItems.Add(new FolioItemDto
                {
                    Type = "Adjustment",
                    Description = charge.Description,
                    Amount = -charge.Amount,
                    CurrencyCode = charge.CurrencyCode,
                    Date = charge.CreatedDate,
                    IsPayment = true
                });
            }

            var payments = await _dbContext.Set<PaymentTransaction>()
                .Include(pt => pt.Charge)
                .Where(pt => pt.Charge.GuestStayId == guestStay.Id && pt.PaymentStatus == OrderPaymentStatusEnum.Paid && !pt.IsDeleted)
                .ToListAsync(cancellationToken);

            foreach (var pt in payments)
            {
                folioItems.Add(new FolioItemDto
                {
                    Type = "Payment",
                    Description = $"Ödeme ({pt.PaymentMethod} - {(string.IsNullOrWhiteSpace(pt.ExternalTransactionId) ? "Online" : pt.ExternalTransactionId)})",
                    Amount = pt.Amount,
                    CurrencyCode = pt.CurrencyCode,
                    Date = pt.PaidAt ?? pt.CreatedDate,
                    IsPayment = true
                });
            }

            var totalCharges = folioItems.Where(x => !x.IsPayment).Sum(x => x.Amount);
            var totalPayments = folioItems.Where(x => x.IsPayment).Sum(x => x.Amount);
            var remainingBalance = totalCharges - totalPayments;

            return new ResponseDto<ReceptionFolioResponse>().Success(new ReceptionFolioResponse
            {
                GuestStayId = guestStay.Id,
                RoomName = guestStay.Room?.Name ?? roomId.ToString(),
                GuestName = string.Join(", ", guestStay.Customers.Select(c => $"{c.Name} {c.SurName}")),
                TotalCharges = totalCharges,
                TotalPayments = totalPayments,
                RemainingBalance = remainingBalance,
                CurrencyCode = guestStay.CurrencyCode,
                Items = folioItems.OrderBy(x => x.Date).ToList()
            });
        }

        [HttpPost("rooms/{roomId:int}/post-payment")]
        public async Task<ResponseDto<bool>> PostPayment(
            int roomId,
            [FromBody] PostPaymentRequest request,
            CancellationToken cancellationToken)
        {
            var guestStay = await _dbContext.Set<GuestStay>()
                .Where(x => x.RoomId == roomId && x.IsActive && !x.IsDeleted && x.ActualCheckOutAt == null)
                .OrderByDescending(x => x.Id)
                .FirstOrDefaultAsync(cancellationToken);

            if (guestStay is null)
            {
                return new ResponseDto<bool>().Fail("Aktif konaklama bulunamadı.", 404);
            }

            if (request.Amount <= 0)
            {
                return new ResponseDto<bool>().Fail("Tutar 0'dan büyük olmalıdır.", 400);
            }

            var charge = new Charge
            {
                GuestStayId = guestStay.Id,
                Description = $"Ödeme Tahsilatı ({request.PaymentMethod ?? "Nakit"})",
                Amount = -request.Amount,
                CurrencyCode = guestStay.CurrencyCode,
                IsPostedToRoom = true,
                PostedToRoomAt = DateTime.UtcNow,
                Status = ChargeStatusEnum.Paid
            };

            await _dbContext.Set<Charge>().AddAsync(charge, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return new ResponseDto<bool>().Success(true);
        }

        [HttpPost("mobile-check-in/update-flags")]
        public async Task<ResponseDto<bool>> UpdateGuestFlags(
            [FromBody] UpdateGuestFlagsRequest request,
            CancellationToken cancellationToken)
        {
            var guestStay = await _dbContext.Set<GuestStay>()
                .FirstOrDefaultAsync(x => x.Id == request.GuestStayId && !x.IsDeleted, cancellationToken);

            if (guestStay is null)
            {
                return new ResponseDto<bool>().Fail("Konaklama kaydı bulunamadı.", 404);
            }

            guestStay.IsVip = request.IsVip;
            guestStay.HasAllergy = request.HasAllergy;
            guestStay.DoNotDisturb = request.DoNotDisturb;
            guestStay.IsLateCheckOut = request.IsLateCheckOut;
            guestStay.ModifyDate = DateTime.Now;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return new ResponseDto<bool>().Success(true);
        }

        [HttpPost("rooms/{roomId:int}/update-status")]
        public async Task<ResponseDto<bool>> UpdateRoomStatus(
            int roomId,
            [FromBody] UpdateRoomStatusRequest request,
            CancellationToken cancellationToken)
        {
            var room = await _dbContext.Set<Room>()
                .FirstOrDefaultAsync(x => x.Id == roomId && !x.IsDeleted, cancellationToken);

            if (room is null)
            {
                return new ResponseDto<bool>().Fail("Oda bulunamadı.", 404);
            }

            var status = request.Status?.Trim();
            if (string.IsNullOrWhiteSpace(status))
            {
                return new ResponseDto<bool>().Fail("Durum boş olamaz.", 400);
            }

            if (status.Equals("Cleaning", StringComparison.OrdinalIgnoreCase) || status.Equals("Temizlikte", StringComparison.OrdinalIgnoreCase) || status.Equals("Kirli", StringComparison.OrdinalIgnoreCase))
            {
                room.CurrentStatus = "Cleaning";
                room.IsFull = false;
            }
            else if (status.Equals("Maintenance", StringComparison.OrdinalIgnoreCase) || status.Equals("Bakımda", StringComparison.OrdinalIgnoreCase) || status.Equals("Arızalı", StringComparison.OrdinalIgnoreCase))
            {
                room.CurrentStatus = "Maintenance";
                room.IsFull = false;
            }
            else if (status.Equals("Available", StringComparison.OrdinalIgnoreCase) || status.Equals("Boş", StringComparison.OrdinalIgnoreCase) || status.Equals("Hazır", StringComparison.OrdinalIgnoreCase))
            {
                room.CurrentStatus = "Available";
                room.IsFull = false;
            }
            else if (status.Equals("Occupied", StringComparison.OrdinalIgnoreCase) || status.Equals("Dolu", StringComparison.OrdinalIgnoreCase))
            {
                room.CurrentStatus = "Occupied";
                room.IsFull = true;
            }
            else
            {
                room.CurrentStatus = status;
            }

            room.ModifyDate = DateTime.Now;
            await _dbContext.SaveChangesAsync(cancellationToken);

            return new ResponseDto<bool>().Success(true);
        }

        [HttpPost("checkout")]
        public async Task<ResponseDto<CheckoutResultDto>> Checkout(
            [FromBody] CheckoutRequest request,
            CancellationToken cancellationToken)
        {
            var guestStay = await _dbContext.Set<GuestStay>()
                .Include(x => x.Room)
                .Include(x => x.Orders)
                .Include(x => x.Charges)
                .Include(x => x.ServiceRequests)
                .FirstOrDefaultAsync(x => x.Id == request.GuestStayId && x.IsActive && !x.IsDeleted && x.ActualCheckOutAt == null, cancellationToken);

            if (guestStay is null)
            {
                return new ResponseDto<CheckoutResultDto>().Fail("Aktif konaklama kaydı bulunamadı.", 404);
            }

            var totalCharges = guestStay.TotalPrice 
                + guestStay.Charges.Where(c => c.Amount > 0 && c.OrderId == null && !c.IsDeleted).Sum(c => c.Amount)
                + guestStay.Orders.Where(o => o.PaymentOption == OrderPaymentOptionEnum.RoomCharge && !o.IsDeleted).Sum(o => o.TotalPrice);
            
            var totalPayments = guestStay.Charges.Where(c => c.Amount < 0 && !c.IsDeleted).Sum(c => -c.Amount);
            var payments = await _dbContext.Set<PaymentTransaction>()
                .Where(pt => pt.Charge.GuestStayId == guestStay.Id && pt.PaymentStatus == OrderPaymentStatusEnum.Paid && !pt.IsDeleted)
                .SumAsync(pt => pt.Amount, cancellationToken);
            totalPayments += payments;

            var balance = totalCharges - totalPayments;

            if (balance > 0.05m && !request.Force)
            {
                return new ResponseDto<CheckoutResultDto>().Success(new CheckoutResultDto
                {
                    Success = false,
                    WarningCode = "UNPAID_BALANCE",
                    Message = $"Odanın {balance:N2} {guestStay.CurrencyCode} ödenmemiş bakiyesi bulunmaktadır."
                });
            }

            var activeRequestsCount = guestStay.ServiceRequests
                .Count(r => r.Status != ServiceRequestStatusEnum.Completed 
                         && r.Status != ServiceRequestStatusEnum.Closed 
                         && r.Status != ServiceRequestStatusEnum.Cancelled 
                         && !r.IsDeleted);

            if (activeRequestsCount > 0 && !request.Force)
            {
                return new ResponseDto<CheckoutResultDto>().Success(new CheckoutResultDto
                {
                    Success = false,
                    WarningCode = "ACTIVE_REQUESTS",
                    Message = $"Odaya ait {activeRequestsCount} adet tamamlanmamış aktif talep bulunmaktadır."
                });
            }

            var strategy = _dbContext.Database.CreateExecutionStrategy();
            return await strategy.ExecuteAsync(async () =>
            {
                await using var transaction = await _dbContext.Database.BeginTransactionAsync(cancellationToken);

                // Reload guestStay and room to track them in potential retry attempts
                var trackingGuestStay = await _dbContext.Set<GuestStay>()
                    .Include(x => x.Room)
                    .FirstOrDefaultAsync(x => x.Id == guestStay.Id, cancellationToken);

                if (trackingGuestStay is null)
                {
                    return new ResponseDto<CheckoutResultDto>().Fail("Aktif konaklama kaydı bulunamadı.", 404);
                }

                trackingGuestStay.ActualCheckOutAt = DateTime.UtcNow;
                trackingGuestStay.Status = "CheckedOut";
                trackingGuestStay.IsMobileAccessEnabled = false;
                trackingGuestStay.ModifyDate = DateTime.Now;

                var sessions = await _dbContext.Set<GuestSession>()
                    .Where(x => x.GuestStayId == trackingGuestStay.Id && x.IsActiveSession && !x.IsDeleted)
                    .ToListAsync(cancellationToken);

                foreach (var session in sessions)
                {
                    session.IsActiveSession = false;
                    session.ExpiresAt = DateTime.UtcNow;
                    session.ModifyDate = DateTime.Now;
                }

                var room = trackingGuestStay.Room;
                if (room is not null)
                {
                    room.IsFull = false;
                    room.CurrentStatus = "Cleaning"; // set room to cleaning/dirty
                    room.ModifyDate = DateTime.Now;
                }

                await _dbContext.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);

                return new ResponseDto<CheckoutResultDto>().Success(new CheckoutResultDto
                {
                    Success = true,
                    Message = "Check-out başarıyla tamamlandı. Oda kirli (Temizlik) durumuna alındı."
                });
            });
        }
    }

    public class PostPaymentRequest
    {
        public decimal Amount { get; set; }
        public string? PaymentMethod { get; set; }
    }

    public class UpdateGuestFlagsRequest
    {
        public int GuestStayId { get; set; }
        public bool IsVip { get; set; }
        public bool HasAllergy { get; set; }
        public bool DoNotDisturb { get; set; }
        public bool IsLateCheckOut { get; set; }
    }

    public class UpdateRoomStatusRequest
    {
        public string Status { get; set; } = string.Empty;
    }

    public class CheckoutRequest
    {
        public int GuestStayId { get; set; }
        public bool Force { get; set; }
    }

    public class CheckoutResultDto
    {
        public bool Success { get; set; }
        public string? WarningCode { get; set; }
        public string Message { get; set; } = string.Empty;
    }

    public class ReceptionFolioResponse
    {
        public int GuestStayId { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public string GuestName { get; set; } = string.Empty;
        public decimal TotalCharges { get; set; }
        public decimal TotalPayments { get; set; }
        public decimal RemainingBalance { get; set; }
        public string CurrencyCode { get; set; } = "TRY";
        public List<FolioItemDto> Items { get; set; } = new();
    }

    public class FolioItemDto
    {
        public string Type { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; } = "TRY";
        public DateTime Date { get; set; }
        public bool IsPayment { get; set; }
    }

    public class ReceptionMobileCheckInRequest
    {
        public int HotelId { get; set; }
        public string RoomName { get; set; } = "101";
        public string CustomerName { get; set; } = "Mobil";
        public string CustomerSurname { get; set; } = "Misafir";
        public int AccommodationConceptType { get; set; } = 5;
        public int StayDays { get; set; } = 1;
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public string LanguageCode { get; set; } = "tr-TR";
        public decimal? Price { get; set; }
        public string CurrencyCode { get; set; } = "TRY";
    }

    public class ReceptionMobileCheckInResponse
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; } = string.Empty;
        public int RoomId { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public int GuestStayId { get; set; }
        public int CustomerId { get; set; }
        public int GuestSessionId { get; set; }
        public string GuestName { get; set; } = string.Empty;
        public string VerificationCode { get; set; } = string.Empty;
        public string SessionToken { get; set; } = string.Empty;
        public string QrCodeToken { get; set; } = string.Empty;
        public string MobileLoginUrl { get; set; } = string.Empty;
        public string QrImageUrl { get; set; } = string.Empty;
        public string LanguageCode { get; set; } = "tr-TR";
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime ExpiresAt { get; set; }
        public decimal BasePrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string CurrencyCode { get; set; } = "TRY";
        public decimal ExchangeRate { get; set; }
        public DateTime ExchangeRateDate { get; set; }
        public bool IsVip { get; set; }
        public bool HasAllergy { get; set; }
        public bool DoNotDisturb { get; set; }
        public bool IsLateCheckOut { get; set; }
    }

    public class CurrencyConversionResult
    {
        public bool IsSuccess { get; set; }
        public decimal ConvertedAmount { get; set; }
        public decimal Rate { get; set; }
        public DateTime RateDate { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;

        public static CurrencyConversionResult Success(decimal convertedAmount, decimal rate, DateTime rateDate)
        {
            return new CurrencyConversionResult
            {
                IsSuccess = true,
                ConvertedAmount = convertedAmount,
                Rate = rate,
                RateDate = rateDate
            };
        }

        public static CurrencyConversionResult Fail(string errorMessage)
        {
            return new CurrencyConversionResult
            {
                IsSuccess = false,
                ErrorMessage = errorMessage
            };
        }
    }
}
