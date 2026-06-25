using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;
using WorigoApp.Persistence.Context;

namespace WorigoApp.Api.Controllers.Reception
{
    /// <summary>
    /// ReceptionRoomsController sınıfını temsil eder.
    /// </summary>
[ApiController]
    [Authorize(Roles = "SystemAdmin,HotelAdmin,Management,DepartmentManager,Employee")]
    [Route("api/reception/rooms")]
    public class ReceptionRoomsController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
/// <summary>
/// ReceptionRoomsController sınıfının yeni bir örneğini başlatır.
/// </summary>
public ReceptionRoomsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Get işlemini gerçekleştirir.
        /// </summary>
[HttpGet]
        public async Task<ResponseDto<IList<ReceptionRoomResponse>>> Get([FromQuery] int hotelId, CancellationToken cancellationToken)
        {
            if (hotelId <= 0)
            {
                return new ResponseDto<IList<ReceptionRoomResponse>>().Fail("HotelId zorunludur.", 400);
            }

            var roomsList = await _dbContext.Set<Room>()
                .AsNoTracking()
                .Include(x => x.RoomType)
                .Where(x => x.HotelId == hotelId && !x.IsDeleted)
                .OrderBy(x => x.FloorNo ?? 0)
                .ThenBy(x => x.RoomNumber ?? x.Name)
                .ToListAsync(cancellationToken);

            var activeStays = await _dbContext.Set<GuestStay>()
                .AsNoTracking()
                .Include(x => x.Orders)
                .Include(x => x.Charges)
                .Include(x => x.Customers)
                .Where(x => x.HotelId == hotelId && x.IsActive && !x.IsDeleted && x.ActualCheckOutAt == null)
                .ToListAsync(cancellationToken);

            var payments = await _dbContext.Set<PaymentTransaction>()
                .AsNoTracking()
                .Where(x => x.Charge.GuestStay.HotelId == hotelId && x.PaymentStatus == OrderPaymentStatusEnum.Paid && !x.IsDeleted)
                .ToListAsync(cancellationToken);

            var rooms = roomsList.Select(r => {
                var stay = activeStays.FirstOrDefault(x => x.RoomId == r.Id);
                var isVip = false;
                var hasAllergy = false;
                var dnd = false;
                var lateCheckout = false;
                var hasUnpaidFolio = false;

                string? guestName = null;
                string? accommodationConcept = null;

                if (stay is not null)
                {
                    isVip = stay.IsVip || stay.AccommodationConceptType == AccommodationConceptTypeEnum.UltraAllInclusive;
                    hasAllergy = stay.HasAllergy;
                    dnd = stay.DoNotDisturb;
                    lateCheckout = stay.IsLateCheckOut;

                    var customer = stay.PrimaryCustomerId.HasValue
                        ? stay.Customers.FirstOrDefault(x => x.Id == stay.PrimaryCustomerId.Value && !x.IsDeleted)
                        : null;
                    customer ??= stay.Customers.FirstOrDefault(x => !x.IsDeleted);
                    guestName = customer is null ? null : $"{customer.Name} {customer.SurName}".Trim();
                    accommodationConcept = stay.AccommodationConceptType switch
                    {
                        AccommodationConceptTypeEnum.RoomOnly => "Sadece Oda",
                        AccommodationConceptTypeEnum.BedAndBreakfast => "Oda Kahvaltı",
                        AccommodationConceptTypeEnum.HalfBoard => "Yarım Pansiyon",
                        AccommodationConceptTypeEnum.FullBoard => "Tam Pansiyon",
                        AccommodationConceptTypeEnum.AllInclusive => "Her Şey Dahil",
                        AccommodationConceptTypeEnum.UltraAllInclusive => "Ultra Her Şey Dahil",
                        _ => stay.AccommodationConceptType.ToString()
                    };

                    // Calculate remaining balance
                    var stayDays = Math.Max(1, (stay.CheckOutDate.Date - stay.CheckInDate.Date).Days);
                    var totalCharges = stay.TotalPrice 
                        + stay.Charges.Where(c => c.Amount > 0 && c.OrderId == null && !c.IsDeleted).Sum(c => c.Amount)
                        + stay.Orders.Where(o => o.PaymentOption == OrderPaymentOptionEnum.RoomCharge && !o.IsDeleted).Sum(o => o.TotalPrice);
                    
                    var totalPayments = stay.Charges.Where(c => c.Amount < 0 && !c.IsDeleted).Sum(c => -c.Amount);
                    var paymentsSum = payments.Where(pt => pt.Charge.GuestStayId == stay.Id).Sum(pt => pt.Amount);
                    totalPayments += paymentsSum;

                    hasUnpaidFolio = (totalCharges - totalPayments) > 0.05m;
                }

                return new ReceptionRoomResponse
                {
                    Id = r.Id,
                    Name = r.Name,
                    RoomNumber = r.RoomNumber,
                    DisplayName = !string.IsNullOrWhiteSpace(r.RoomNumber) ? r.RoomNumber! : r.Name,
                    RoomTypeId = r.RoomTypeId,
                    RoomType = r.RoomType != null ? r.RoomType.Name : string.Empty,
                    RoomTypeValue = r.RoomType != null ? r.RoomTypeId : 0,
                    FloorNo = r.FloorNo,
                    Capacity = r.Capacity,
                    Description = r.Description,
                    IsFull = r.IsFull,
                    CurrentStatus = r.CurrentStatus,
                    Price = r.Price,
                    InternalPhoneNumber = r.InternalPhoneNumber,
                    
                    // Badges
                    IsVip = isVip,
                    HasAllergy = hasAllergy,
                    DoNotDisturb = dnd,
                    IsLateCheckOut = lateCheckout,
                    HasUnpaidFolio = hasUnpaidFolio,
                    CheckInDate = stay?.CheckInDate,
                    CheckOutDate = stay?.CheckOutDate,
                    GuestName = guestName,
                    AccommodationConcept = accommodationConcept
                };
            }).ToList();
 
            return new ResponseDto<IList<ReceptionRoomResponse>>().Success(rooms);
        }
    }
 
/// <summary>
/// ReceptionRoomResponse sınıfını temsil eder.
/// </summary>
public class ReceptionRoomResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; } = string.Empty;
/// <summary>
/// RoomNumber değerini alır veya ayarlar.
/// </summary>
public string? RoomNumber { get; set; }
/// <summary>
/// DisplayName değerini alır veya ayarlar.
/// </summary>
public string DisplayName { get; set; } = string.Empty;
/// <summary>
/// RoomTypeId değerini alır veya ayarlar.
/// </summary>
public int RoomTypeId { get; set; }
/// <summary>
/// RoomType değerini alır veya ayarlar.
/// </summary>
public string RoomType { get; set; } = string.Empty;
/// <summary>
/// RoomTypeValue değerini alır veya ayarlar.
/// </summary>
public int RoomTypeValue { get; set; }
/// <summary>
/// FloorNo değerini alır veya ayarlar.
/// </summary>
public int? FloorNo { get; set; }
/// <summary>
/// Capacity değerini alır veya ayarlar.
/// </summary>
public int Capacity { get; set; }
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string? Description { get; set; }
/// <summary>
/// IsFull değerini alır veya ayarlar.
/// </summary>
public bool IsFull { get; set; }
/// <summary>
/// CurrentStatus değerini alır veya ayarlar.
/// </summary>
public string CurrentStatus { get; set; } = string.Empty;
/// <summary>
/// Price değerini alır veya ayarlar.
/// </summary>
public decimal Price { get; set; }
/// <summary>
/// InternalPhoneNumber değerini alır veya ayarlar.
/// </summary>
public string? InternalPhoneNumber { get; set; }
 
/// <summary>
/// IsVip değerini alır veya ayarlar.
/// </summary>
public bool IsVip { get; set; }
/// <summary>
/// HasAllergy değerini alır veya ayarlar.
/// </summary>
public bool HasAllergy { get; set; }
/// <summary>
/// DoNotDisturb değerini alır veya ayarlar.
/// </summary>
public bool DoNotDisturb { get; set; }
/// <summary>
/// IsLateCheckOut değerini alır veya ayarlar.
/// </summary>
public bool IsLateCheckOut { get; set; }
/// <summary>
/// HasUnpaidFolio değerini alır veya ayarlar.
/// </summary>
public bool HasUnpaidFolio { get; set; }
/// <summary>
/// CheckInDate değerini alır veya ayarlar.
/// </summary>
public DateTime? CheckInDate { get; set; }
/// <summary>
/// CheckOutDate değerini alır veya ayarlar.
/// </summary>
public DateTime? CheckOutDate { get; set; }
/// <summary>
/// GuestName değerini alır veya ayarlar.
/// </summary>
public string? GuestName { get; set; }
/// <summary>
/// AccommodationConcept değerini alır veya ayarlar.
/// </summary>
public string? AccommodationConcept { get; set; }
    }
}
