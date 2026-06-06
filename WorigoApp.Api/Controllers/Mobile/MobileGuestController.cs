using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Api.Hubs;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Conversations.Commands.StartConversationFlow;
using WorigoApp.Application.Features.ServiceRequests.Commands.CreateServiceRequest;
using WorigoApp.Application.Features.ServiceRequests.Dtos;
using WorigoApp.Application.Features.ServiceRequests.Queries.GetServiceRequestsByGuestStay;
using WorigoApp.Application.Features.GuestServices.Queries.GetGuestAvailableServices;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;
using WorigoApp.Persistence.Context;

namespace WorigoApp.Api.Controllers.Mobile
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/mobile/guest")]
    public class MobileGuestController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly IMediator _mediator;
        private readonly IHubContext<HotelOperationsHub> _hubContext;
        private static readonly HashSet<string> SupportedMobileLanguageCodes = new(StringComparer.OrdinalIgnoreCase)
        {
            "tr-TR",
            "en-US",
            "de-DE",
            "fr-FR",
            "ar-SA",
            "ru-RU",
            "es-ES"
        };

        public MobileGuestController(AppDbContext dbContext, IMediator mediator, IHubContext<HotelOperationsHub> hubContext)
        {
            _dbContext = dbContext;
            _mediator = mediator;
            _hubContext = hubContext;
        }

        [HttpPost("qr-login")]
        public async Task<ResponseDto<MobileGuestSessionResponse>> QrLogin(MobileGuestQrLoginRequest request, CancellationToken cancellationToken)
        {
            var qrCodeToken = ExtractQrToken(request.QrCodeToken);
            if (string.IsNullOrWhiteSpace(qrCodeToken))
            {
                return new ResponseDto<MobileGuestSessionResponse>().Fail("QR token zorunludur.", 400);
            }

            var session = await FindActiveSessionAsync(qrCodeToken: qrCodeToken, sessionToken: null, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<MobileGuestSessionResponse>().Fail("QR oturumu bulunamadi veya suresi doldu.", 404);
            }

            session.LastAccessAt = DateTime.UtcNow;
            await _dbContext.SaveChangesAsync(cancellationToken);

            return new ResponseDto<MobileGuestSessionResponse>().Success(ToResponse(session));
        }

        [HttpGet("services/{sessionToken}")]
        public async Task<ResponseDto<IList<GetGuestAvailableServicesQueryResponse>>> GetServices(string sessionToken, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: sessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<IList<GetGuestAvailableServicesQueryResponse>>().Fail("Misafir oturumu bulunamadi veya suresi doldu.", 404);
            }

            session.LastAccessAt = DateTime.UtcNow;
            await _dbContext.SaveChangesAsync(cancellationToken);

            return await _mediator.Send(new GetGuestAvailableServicesQueryRequest
            {
                GuestStayId = session.GuestStayId
            }, cancellationToken);
        }

        [HttpGet("service-catalog-version/{sessionToken}")]
        public async Task<ResponseDto<string>> GetServiceCatalogVersion(string sessionToken, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: sessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<string>().Fail("Misafir oturumu bulunamadi veya suresi doldu.", 404);
            }

            var categoryVersion = await _dbContext.ServiceCategories
                .Where(x => x.HotelId == session.GuestStay.HotelId)
                .MaxAsync(x => (DateTime?)x.ModifyDate, cancellationToken);
            var definitionVersion = await _dbContext.ServiceDefinitions
                .Where(x => x.HotelId == session.GuestStay.HotelId)
                .MaxAsync(x => (DateTime?)x.ModifyDate, cancellationToken);
            var policyVersion = await _dbContext.HotelServicePolicies
                .Where(x => x.HotelId == session.GuestStay.HotelId)
                .MaxAsync(x => (DateTime?)x.ModifyDate, cancellationToken);
            var foodVersion = await _dbContext.Food
                .Where(x => x.FoodMenuCategory.HotelId == session.GuestStay.HotelId)
                .MaxAsync(x => (DateTime?)x.ModifyDate, cancellationToken);
            var foodCategoryVersion = await _dbContext.FoodMenuCategory
                .Where(x => x.HotelId == session.GuestStay.HotelId)
                .MaxAsync(x => (DateTime?)x.ModifyDate, cancellationToken);

            var version = new[] { categoryVersion, definitionVersion, policyVersion, foodVersion, foodCategoryVersion }
                .Where(x => x.HasValue)
                .Select(x => x!.Value)
                .DefaultIfEmpty(DateTime.MinValue)
                .Max()
                .Ticks
                .ToString();

            return new ResponseDto<string>().Success(version);
        }

        [HttpGet("quick-actions/{sessionToken}")]
        public async Task<ResponseDto<IList<MobileGuestQuickActionResponse>>> GetQuickActions(string sessionToken, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: sessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<IList<MobileGuestQuickActionResponse>>().Fail("Misafir oturumu bulunamadi veya suresi doldu.", 404);
            }

            session.LastAccessAt = DateTime.UtcNow;
            await _dbContext.SaveChangesAsync(cancellationToken);

            var servicesResponse = await _mediator.Send(new GetGuestAvailableServicesQueryRequest
            {
                GuestStayId = session.GuestStayId
            }, cancellationToken);

            if (!servicesResponse.IsSuccess || servicesResponse.Data is null)
            {
                return new ResponseDto<IList<MobileGuestQuickActionResponse>>()
                    .Fail(servicesResponse.Errors ?? new List<string> { "Hizli servisler listelenemedi." }, servicesResponse.StatusCode);
            }

            var quickActions = servicesResponse.Data
                .GroupBy(x => new
                {
                    x.ServiceCategoryId,
                    DisplayName = x.ServiceCategoryName ?? x.Name,
                    x.ServiceType
                })
                .Select(group =>
                {
                    var first = group.OrderBy(x => x.DisplayOrder).ThenBy(x => x.Name).First();
                    var category = first.ServiceCategoryId.HasValue
                        ? _dbContext.ServiceCategories.FirstOrDefault(x => x.Id == first.ServiceCategoryId.Value)
                        : null;
                    return new MobileGuestQuickActionResponse
                    {
                        ServiceCategoryId = group.Key.ServiceCategoryId,
                        ServiceDefinitionId = group.Count() == 1 ? first.ServiceDefinitionId : null,
                        ServiceType = group.Key.ServiceType,
                        DisplayName = group.Key.DisplayName,
                        IconKey = category?.IconKey,
                        ShowOnHome = category?.ShowOnHome ?? true,
                        IsPopular = category?.IsPopular ?? true,
                        HomeDisplayOrder = category?.HomeDisplayOrder,
                        PreviewImageUrl = first.ImageUrl,
                        DisplayOrder = group.Min(x => x.DisplayOrder),
                        OpeningMessageType = first.OpeningMessageType,
                        OpeningMessage = group.Count() == 1
                            ? first.OpeningMessage
                            : $"Merhaba, {group.Key.DisplayName} icin hangi hizmete ihtiyaciniz var?",
                        OpeningPayloadJson = group.Count() == 1
                            ? first.OpeningPayloadJson
                            : System.Text.Json.JsonSerializer.Serialize(new
                            {
                                uiType = first.FlowUiType.ToString(),
                                title = $"Merhaba, {group.Key.DisplayName} icin hangi hizmete ihtiyaciniz var?",
                                options = group
                                    .OrderBy(x => x.DisplayOrder)
                                    .ThenBy(x => x.Name)
                                    .Select(x => new
                                    {
                                        label = x.Name,
                                        value = x.ServiceDefinitionId?.ToString() ?? x.ServiceItemId.ToString(),
                                        serviceDefinitionId = x.ServiceDefinitionId,
                                        serviceItemId = x.ServiceItemId
                                    })
                            }),
                        ItemCount = group.Count()
                    };
                })
                .Where(x => x.ShowOnHome)
                .OrderBy(x => x.HomeDisplayOrder ?? x.DisplayOrder)
                .ThenBy(x => x.DisplayName)
                .Take(4)
                .ToList();

            return new ResponseDto<IList<MobileGuestQuickActionResponse>>().Success(quickActions);
        }

        [HttpGet("service-categories/{sessionToken}")]
        public async Task<ResponseDto<IList<MobileGuestServiceCategoryResponse>>> GetServiceCategories(string sessionToken, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: sessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<IList<MobileGuestServiceCategoryResponse>>().Fail("Misafir oturumu bulunamadi veya suresi doldu.", 404);
            }

            session.LastAccessAt = DateTime.UtcNow;
            await _dbContext.SaveChangesAsync(cancellationToken);

            var servicesResponse = await _mediator.Send(new GetGuestAvailableServicesQueryRequest
            {
                GuestStayId = session.GuestStayId
            }, cancellationToken);

            if (!servicesResponse.IsSuccess || servicesResponse.Data is null)
            {
                return new ResponseDto<IList<MobileGuestServiceCategoryResponse>>()
                    .Fail(servicesResponse.Errors ?? new List<string> { "Servis kategorileri listelenemedi." }, servicesResponse.StatusCode);
            }

            var categoryIds = servicesResponse.Data
                .Where(x => x.ServiceCategoryId.HasValue)
                .Select(x => x.ServiceCategoryId!.Value)
                .Distinct()
                .ToList();

            var categories = await _dbContext.ServiceCategories
                .Where(x => categoryIds.Contains(x.Id) && x.IsActive && !x.IsDeleted)
                .OrderBy(x => x.DisplayOrder)
                .ToListAsync(cancellationToken);

            var response = categories.Select(category =>
            {
                var categoryItems = servicesResponse.Data
                    .Where(x =>
                        x.ServiceCategoryId == category.Id ||
                        (!x.ServiceCategoryId.HasValue &&
                         category.LegacyServiceType.HasValue &&
                         x.ServiceType == category.LegacyServiceType.Value.ToString()))
                    .ToList();
                return new MobileGuestServiceCategoryResponse
                {
                    ServiceCategoryId = category.Id,
                    DisplayName = categoryItems.Select(x => x.ServiceCategoryName).FirstOrDefault(x => !string.IsNullOrWhiteSpace(x)) ?? category.Name,
                    Description = category.Description,
                    IconKey = category.IconKey,
                    IconUrl = category.IconUrl,
                    DisplayOrder = category.DisplayOrder,
                    ShowOnHome = category.ShowOnHome,
                    IsPopular = category.IsPopular,
                    HomeDisplayOrder = category.HomeDisplayOrder,
                    ItemCount = categoryItems.Count,
                    ContainsChargeableItems = categoryItems.Any(x => x.IsChargeable),
                    PreviewImageUrl = categoryItems.Select(x => x.ImageUrl).FirstOrDefault(x => !string.IsNullOrWhiteSpace(x))
                };
            }).ToList();

            return new ResponseDto<IList<MobileGuestServiceCategoryResponse>>().Success(response);
        }

        [HttpGet("service-categories/{categoryId:int}/items/{sessionToken}")]
        public async Task<ResponseDto<IList<GetGuestAvailableServicesQueryResponse>>> GetServiceCategoryItems(int categoryId, string sessionToken, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: sessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<IList<GetGuestAvailableServicesQueryResponse>>().Fail("Misafir oturumu bulunamadi veya suresi doldu.", 404);
            }

            session.LastAccessAt = DateTime.UtcNow;
            await _dbContext.SaveChangesAsync(cancellationToken);

            var servicesResponse = await _mediator.Send(new GetGuestAvailableServicesQueryRequest
            {
                GuestStayId = session.GuestStayId
            }, cancellationToken);

            if (!servicesResponse.IsSuccess || servicesResponse.Data is null)
            {
                return servicesResponse;
            }

            var category = await _dbContext.ServiceCategories
                .FirstOrDefaultAsync(x => x.Id == categoryId && x.IsActive && !x.IsDeleted, cancellationToken);

            return new ResponseDto<IList<GetGuestAvailableServicesQueryResponse>>()
                .Success(servicesResponse.Data
                    .Where(x =>
                        x.ServiceCategoryId == categoryId ||
                        (!x.ServiceCategoryId.HasValue &&
                         category != null &&
                         category.LegacyServiceType.HasValue &&
                         x.ServiceType == category.LegacyServiceType.Value.ToString()))
                    .OrderBy(x => x.DisplayOrder)
                    .ThenBy(x => x.Name)
                    .ToList());
        }

        [HttpGet("announcements/{sessionToken}")]
        public async Task<ResponseDto<IList<MobileGuestAnnouncementResponse>>> GetGuestAnnouncementsBySessionToken(string sessionToken, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: sessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<IList<MobileGuestAnnouncementResponse>>().Fail("Misafir oturumu bulunamadi veya suresi doldu.", 404);
            }

            var now = DateTime.UtcNow;
            var announcementEntities = await _dbContext.Announcements
                .AsNoTracking()
                .Where(x =>
                    x.HotelId == session.GuestStay.HotelId &&
                    x.IsVisibleToGuest &&
                    x.IsActive &&
                    !x.IsDeleted &&
                    x.StartAt <= now &&
                    (!x.EndAt.HasValue || x.EndAt >= now))
                .OrderByDescending(x => x.IsPinned)
                .ThenByDescending(x => x.StartAt)
                .ToListAsync(cancellationToken);

            var announcements = announcementEntities
                .Select(x => new MobileGuestAnnouncementResponse
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    ImageUrl = BuildAbsoluteUrl(x.ImageUrl),
                    Type = x.Type.ToString(),
                    StartAt = x.StartAt,
                    EndAt = x.EndAt,
                    Location = x.Location,
                    IsPinned = x.IsPinned
                })
                .ToList();

            return new ResponseDto<IList<MobileGuestAnnouncementResponse>>().Success(announcements);
        }

        private string? BuildAbsoluteUrl(string? path)
        {
            if (string.IsNullOrWhiteSpace(path) || Uri.TryCreate(path, UriKind.Absolute, out _))
            {
                return path;
            }

            return $"{Request.Scheme}://{Request.Host}/{path.TrimStart('/')}";
        }

        [HttpPost("language")]
        public async Task<ResponseDto<MobileGuestSessionResponse>> UpdateLanguage(MobileGuestUpdateLanguageRequest request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.SessionToken))
            {
                return new ResponseDto<MobileGuestSessionResponse>().Fail("Misafir oturumu zorunludur.", 400);
            }

            var languageCode = NormalizeLanguageCode(request.LanguageCode);
            if (!SupportedMobileLanguageCodes.Contains(languageCode))
            {
                return new ResponseDto<MobileGuestSessionResponse>().Fail("Desteklenmeyen dil secimi.", 400);
            }

            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: request.SessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<MobileGuestSessionResponse>().Fail("Misafir oturumu bulunamadi veya suresi doldu.", 404);
            }

            session.LanguageCode = languageCode;
            session.LastAccessAt = DateTime.UtcNow;
            session.GuestStay.GuestLanguageCode = languageCode;
            session.GuestStay.ModifyDate = DateTime.Now;

            if (session.Customer is not null)
            {
                session.Customer.PreferredLanguageCode = languageCode;
                session.Customer.ModifyDate = DateTime.Now;
            }

            await _dbContext.SaveChangesAsync(cancellationToken);

            return new ResponseDto<MobileGuestSessionResponse>().Success(ToResponse(session));
        }

        [HttpPost("service-request")]
        public async Task<ResponseDto<CreateServiceRequestCommandResponse>> CreateServiceRequest(MobileGuestCreateServiceRequest request, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: request.SessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<CreateServiceRequestCommandResponse>().Fail("Misafir oturumu bulunamadi veya suresi doldu.", 404);
            }

            session.LastAccessAt = DateTime.UtcNow;
            await _dbContext.SaveChangesAsync(cancellationToken);

            var response = await _mediator.Send(new CreateServiceRequestCommandRequest
            {
                GuestStayId = session.GuestStayId,
                RoomId = session.GuestStay.RoomId,
                CustomerId = session.CustomerId,
                ServiceType = request.ServiceType,
                ServiceCatalogItemId = request.ServiceItemId,
                ServiceDefinitionId = request.ServiceDefinitionId,
                ConversationId = request.ConversationId,
                Title = string.IsNullOrWhiteSpace(request.Title) ? "Servis talebi" : request.Title.Trim(),
                Description = request.Description,
                LanguageCode = string.IsNullOrWhiteSpace(session.LanguageCode) ? "tr-TR" : session.LanguageCode,
                Priority = request.Priority,
                FieldValues = request.FieldValues,
                Items = request.Items
            }, cancellationToken);

            if (response.IsSuccess && response.Data is not null)
            {
                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Hotel(response.Data.HotelId))
                    .SendAsync("ServiceRequestCreated", response.Data, cancellationToken);

                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Reception(response.Data.HotelId))
                    .SendAsync("ServiceRequestCreated", response.Data, cancellationToken);

                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.GuestStay(response.Data.GuestStayId))
                    .SendAsync("ServiceRequestCreated", response.Data, cancellationToken);

                if (response.Data.DepartmentId.HasValue)
                {
                    await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Department(response.Data.DepartmentId.Value))
                        .SendAsync("ServiceRequestCreated", response.Data, cancellationToken);
                }

                if (response.Data.AssignedEmployeeId.HasValue)
                {
                    await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Employee(response.Data.AssignedEmployeeId.Value))
                        .SendAsync("ServiceRequestAssigned", response.Data, cancellationToken);
                }

                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Hotel(response.Data.HotelId))
                    .SendAsync("NotificationReceived", response.Data, cancellationToken);

                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Reception(response.Data.HotelId))
                    .SendAsync("NotificationReceived", response.Data, cancellationToken);

                foreach (var receptionEmployeeId in response.Data.ReceptionEmployeeIds)
                {
                    await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Employee(receptionEmployeeId))
                        .SendAsync("NotificationReceived", response.Data, cancellationToken);
                }
            }

            return response;
        }

        [HttpPost("start-flow")]
        public async Task<ResponseDto<StartConversationFlowCommandResponse>> StartFlow(MobileGuestStartFlowRequest request, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: request.SessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<StartConversationFlowCommandResponse>().Fail("Misafir oturumu bulunamadi veya suresi doldu.", 404);
            }

            session.LastAccessAt = DateTime.UtcNow;
            await _dbContext.SaveChangesAsync(cancellationToken);

            return await _mediator.Send(new StartConversationFlowCommandRequest
            {
                GuestStayId = session.GuestStayId,
                CustomerId = session.CustomerId,
                ServiceCategoryId = request.ServiceCategoryId,
                ServiceDefinitionId = request.ServiceDefinitionId,
                FlowType = request.FlowType,
                CurrentStep = string.IsNullOrWhiteSpace(request.CurrentStep) ? "start" : request.CurrentStep,
                StateJson = string.IsNullOrWhiteSpace(request.StateJson) ? "{}" : request.StateJson,
                Subject = request.Subject,
                LanguageCode = string.IsNullOrWhiteSpace(session.LanguageCode) ? "tr-TR" : session.LanguageCode,
                OpeningMessage = request.OpeningMessage,
                OpeningMessageType = request.OpeningMessageType,
                OpeningPayloadJson = request.OpeningPayloadJson
            }, cancellationToken);
        }


        [HttpGet("my-requests/{sessionToken}")]
        public async Task<ResponseDto<IList<GetServiceRequestsByGuestStayQueryResponse>>> GetMyRequests(string sessionToken, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: sessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<IList<GetServiceRequestsByGuestStayQueryResponse>>().Fail("Misafir oturumu bulunamadi veya suresi doldu.", 404);
            }

            session.LastAccessAt = DateTime.UtcNow;
            await _dbContext.SaveChangesAsync(cancellationToken);

            return await _mediator.Send(new GetServiceRequestsByGuestStayQueryRequest
            {
                GuestStayId = session.GuestStayId
            }, cancellationToken);
        }

        private async Task<GuestSession?> FindActiveSessionAsync(string? qrCodeToken, string? sessionToken, CancellationToken cancellationToken)
        {
            var now = DateTime.UtcNow;
            var today = DateTime.Today;

            return await _dbContext.GuestSessions
                .Include(x => x.GuestStay)
                    .ThenInclude(x => x.Room)
                        .ThenInclude(x => x.Hotel)
                .Include(x => x.Customer)
                .FirstOrDefaultAsync(x =>
                    (qrCodeToken == null || x.QrCodeToken == qrCodeToken) &&
                    (sessionToken == null || x.SessionToken == sessionToken) &&
                    x.IsActiveSession &&
                    x.IsActive &&
                    !x.IsDeleted &&
                    x.ExpiresAt > now &&
                    x.GuestStay.IsActive &&
                    !x.GuestStay.IsDeleted &&
                    x.GuestStay.IsMobileAccessEnabled &&
                    x.GuestStay.CheckInDate.Date <= today &&
                    x.GuestStay.CheckOutDate.Date >= today &&
                    x.GuestStay.ActualCheckOutAt == null,
                    cancellationToken);
        }

        private static string ExtractQrToken(string? rawValue)
        {
            if (string.IsNullOrWhiteSpace(rawValue))
            {
                return string.Empty;
            }

            var value = rawValue.Trim();
            if (Uri.TryCreate(value, UriKind.Absolute, out var uri))
            {
                var query = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(uri.Query);
                if (query.TryGetValue("qrCodeToken", out var qrCodeToken))
                {
                    return qrCodeToken.ToString();
                }

                if (query.TryGetValue("token", out var token))
                {
                    return token.ToString();
                }
            }

            return value;
        }

        private static string NormalizeLanguageCode(string? languageCode)
        {
            var code = string.IsNullOrWhiteSpace(languageCode) ? "tr-TR" : languageCode.Trim();
            return code.Split('-', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).FirstOrDefault()?.ToLowerInvariant() switch
            {
                "tr" => "tr-TR",
                "en" => "en-US",
                "de" => "de-DE",
                "fr" => "fr-FR",
                "ar" => "ar-SA",
                "ru" => "ru-RU",
                "es" => "es-ES",
                _ => code
            };
        }

        private static MobileGuestSessionResponse ToResponse(GuestSession session)
        {
            return new MobileGuestSessionResponse
            {
                GuestSessionId = session.Id,
                GuestStayId = session.GuestStayId,
                CustomerId = session.CustomerId ?? 0,
                HotelId = session.GuestStay.HotelId,
                HotelName = session.GuestStay.Room?.Hotel?.Name ?? string.Empty,
                RoomName = session.GuestStay.Room?.Name ?? session.GuestStay.RoomId.ToString(),
                GuestName = session.Customer is null ? string.Empty : $"{session.Customer.Name} {session.Customer.SurName}".Trim(),
                SessionToken = session.SessionToken,
                LanguageCode = session.LanguageCode,
                CheckInDate = session.GuestStay.CheckInDate,
                CheckOutDate = session.GuestStay.CheckOutDate
            };
        }

        [HttpGet("folio/{sessionToken}")]
        public async Task<ResponseDto<MobileFolioResponse>> GetFolio(string sessionToken, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: sessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<MobileFolioResponse>().Fail("Misafir oturumu bulunamadı veya süresi doldu.", 404);
            }

            var guestStay = await _dbContext.Set<GuestStay>()
                .Include(x => x.Room)
                .Include(x => x.Customers)
                .Include(x => x.Orders)
                    .ThenInclude(x => x.OrderItems)
                .Include(x => x.Charges)
                .FirstOrDefaultAsync(x => x.Id == session.GuestStayId, cancellationToken);

            if (guestStay is null)
            {
                return new ResponseDto<MobileFolioResponse>().Fail("Konaklama kaydı bulunamadı.", 404);
            }

            var stayDays = Math.Max(1, (guestStay.CheckOutDate.Date - guestStay.CheckInDate.Date).Days);

            var folioItems = new List<MobileFolioItemDto>
            {
                new MobileFolioItemDto
                {
                    Description = $"Oda Konaklama Bedeli ({stayDays} Gece)",
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
                folioItems.Add(new MobileFolioItemDto
                {
                    Description = $"Sipariş #{order.OrderNumber}{itemsStr}",
                    Amount = order.TotalPrice,
                    CurrencyCode = order.CurrencyCode,
                    Date = order.CreatedDate,
                    IsPayment = false
                });
            }

            foreach (var charge in guestStay.Charges.Where(c => c.Amount > 0 && c.OrderId == null && !c.IsDeleted))
            {
                folioItems.Add(new MobileFolioItemDto
                {
                    Description = charge.Description,
                    Amount = charge.Amount,
                    CurrencyCode = charge.CurrencyCode,
                    Date = charge.CreatedDate,
                    IsPayment = false
                });
            }

            foreach (var charge in guestStay.Charges.Where(c => c.Amount < 0 && !c.IsDeleted))
            {
                folioItems.Add(new MobileFolioItemDto
                {
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
                folioItems.Add(new MobileFolioItemDto
                {
                    Description = $"Ödeme ({pt.PaymentMethod})",
                    Amount = pt.Amount,
                    CurrencyCode = pt.CurrencyCode,
                    Date = pt.PaidAt ?? pt.CreatedDate,
                    IsPayment = true
                });
            }

            var totalCharges = folioItems.Where(x => !x.IsPayment).Sum(x => x.Amount);
            var totalPayments = folioItems.Where(x => x.IsPayment).Sum(x => x.Amount);
            var remainingBalance = totalCharges - totalPayments;

            return new ResponseDto<MobileFolioResponse>().Success(new MobileFolioResponse
            {
                GuestStayId = guestStay.Id,
                RoomName = guestStay.Room?.Name ?? guestStay.RoomId.ToString(),
                GuestName = $"{session.Customer?.Name} {session.Customer?.SurName}".Trim(),
                TotalCharges = totalCharges,
                TotalPayments = totalPayments,
                RemainingBalance = remainingBalance,
                CurrencyCode = guestStay.CurrencyCode,
                Items = folioItems.OrderBy(x => x.Date).ToList()
            });
        }

        [HttpPost("checkout")]
        public async Task<ResponseDto<MobileCheckoutResultDto>> Checkout(MobileCheckoutRequest request, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: request.SessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<MobileCheckoutResultDto>().Fail("Misafir oturumu bulunamadı veya süresi doldu.", 404);
            }

            var guestStay = await _dbContext.Set<GuestStay>()
                .Include(x => x.Room)
                .Include(x => x.Orders)
                .Include(x => x.Charges)
                .Include(x => x.ServiceRequests)
                .FirstOrDefaultAsync(x => x.Id == session.GuestStayId, cancellationToken);

            if (guestStay is null)
            {
                return new ResponseDto<MobileCheckoutResultDto>().Fail("Konaklama kaydı bulunamadı.", 404);
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
                return new ResponseDto<MobileCheckoutResultDto>().Success(new MobileCheckoutResultDto
                {
                    Success = false,
                    WarningCode = "UNPAID_BALANCE",
                    Message = $"Odanızın {balance:N2} {guestStay.CurrencyCode} ödenmemiş bakiyesi bulunmaktadır. Lütfen çıkış yapmadan önce ödemeyi resepsiyona veya online olarak yapınız."
                });
            }

            var activeRequestsCount = guestStay.ServiceRequests
                .Count(r => r.Status != ServiceRequestStatusEnum.Completed 
                         && r.Status != ServiceRequestStatusEnum.Closed 
                         && r.Status != ServiceRequestStatusEnum.Cancelled 
                         && !r.IsDeleted);

            if (activeRequestsCount > 0 && !request.Force)
            {
                return new ResponseDto<MobileCheckoutResultDto>().Success(new MobileCheckoutResultDto
                {
                    Success = false,
                    WarningCode = "ACTIVE_REQUESTS",
                    Message = "Odanıza ait tamamlanmamış aktif hizmet talepleri bulunmaktadır. Yine de çıkış yapmak istiyor musunuz?"
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
                    return new ResponseDto<MobileCheckoutResultDto>().Fail("Aktif konaklama kaydı bulunamadı.", 404);
                }

                trackingGuestStay.ActualCheckOutAt = DateTime.UtcNow;
                trackingGuestStay.Status = "CheckedOut";
                trackingGuestStay.IsMobileAccessEnabled = false;
                trackingGuestStay.ModifyDate = DateTime.Now;

                var sessions = await _dbContext.Set<GuestSession>()
                    .Where(x => x.GuestStayId == trackingGuestStay.Id && x.IsActiveSession && !x.IsDeleted)
                    .ToListAsync(cancellationToken);

                foreach (var s in sessions)
                {
                    s.IsActiveSession = false;
                    s.ExpiresAt = DateTime.UtcNow;
                    s.ModifyDate = DateTime.Now;
                }

                var room = trackingGuestStay.Room;
                if (room is not null)
                {
                    room.IsFull = false;
                    room.CurrentStatus = "Cleaning";
                    room.ModifyDate = DateTime.Now;
                }

                await _dbContext.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);

                // SignalR hub notification of checkout
                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Reception(trackingGuestStay.HotelId))
                    .SendAsync("NotificationReceived", new { Title = "Mobil Check-out", Description = $"{room?.Name ?? "Oda"} misafiri mobil uygulamadan çıkış yaptı." }, cancellationToken);

                return new ResponseDto<MobileCheckoutResultDto>().Success(new MobileCheckoutResultDto
                {
                    Success = true,
                    Message = "Oda çıkış işleminiz başarıyla tamamlandı. Teşekkür ederiz!"
                });
            });
        }

        [HttpGet("iot/{sessionToken}")]
        public async Task<ResponseDto<MobileRoomIotResponse>> GetRoomIotState(string sessionToken, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: sessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<MobileRoomIotResponse>().Fail("Misafir oturumu bulunamadı veya süresi doldu.", 404);
            }

            var room = await _dbContext.Room.FirstOrDefaultAsync(x => x.Id == session.GuestStay.RoomId, cancellationToken);
            if (room is null)
            {
                return new ResponseDto<MobileRoomIotResponse>().Fail("Oda bulunamadı.", 404);
            }

            return new ResponseDto<MobileRoomIotResponse>().Success(new MobileRoomIotResponse
            {
                TargetTemperature = room.TargetTemperature,
                LightsIntensity = room.LightsIntensity,
                AreCurtainsOpen = room.AreCurtainsOpen
            });
        }

        [HttpPost("iot/update")]
        public async Task<ResponseDto<bool>> UpdateRoomIotState(MobileRoomIotUpdateRequest request, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: request.SessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<bool>().Fail("Misafir oturumu bulunamadı veya süresi doldu.", 404);
            }

            var room = await _dbContext.Room.FirstOrDefaultAsync(x => x.Id == session.GuestStay.RoomId, cancellationToken);
            if (room is null)
            {
                return new ResponseDto<bool>().Fail("Oda bulunamadı.", 404);
            }

            room.TargetTemperature = request.TargetTemperature;
            room.LightsIntensity = request.LightsIntensity;
            room.AreCurtainsOpen = request.AreCurtainsOpen;
            room.ModifyDate = DateTime.Now;

            await _dbContext.SaveChangesAsync(cancellationToken);
            return new ResponseDto<bool>().Success(true);
        }

        [HttpGet("spa/services/{sessionToken}")]
        public async Task<ResponseDto<IList<MobileSpaServiceResponse>>> GetSpaServices(string sessionToken, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: sessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<IList<MobileSpaServiceResponse>>().Fail("Misafir oturumu bulunamadı veya süresi doldu.", 404);
            }

            var services = new List<MobileSpaServiceResponse>
            {
                new MobileSpaServiceResponse { Name = "Aromaterapi Masajı", Description = "Uçucu yağlar ile rahatlatıcı masaj deneyimi.", Price = 1200m, Duration = "50 Dk" },
                new MobileSpaServiceResponse { Name = "İsveç Masajı", Description = "Kas gevşetici klasik masaj terapisi.", Price = 1000m, Duration = "60 Dk" },
                new MobileSpaServiceResponse { Name = "Türk Hamamı Ritüeli", Description = "Geleneksel kese ve köpük masajı.", Price = 900m, Duration = "45 Dk" },
                new MobileSpaServiceResponse { Name = "Cilt Bakımı & Detox", Description = "Profesyonel cilt temizleme ve nemlendirme.", Price = 1500m, Duration = "75 Dk" }
            };

            return new ResponseDto<IList<MobileSpaServiceResponse>>().Success(services);
        }

        [HttpGet("spa/slots/{sessionToken}")]
        public async Task<ResponseDto<IList<string>>> GetSpaSlots(string sessionToken, [FromQuery] DateTime date, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: sessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<IList<string>>().Fail("Misafir oturumu bulunamadı veya süresi doldu.", 404);
            }

            var slots = new List<string> { "09:00", "10:30", "12:00", "13:30", "15:00", "16:30", "18:00", "19:30" };
            return new ResponseDto<IList<string>>().Success(slots);
        }

        [HttpPost("spa/book")]
        public async Task<ResponseDto<bool>> BookSpaAppointment(MobileSpaBookRequest request, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: request.SessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<bool>().Fail("Misafir oturumu bulunamadı veya süresi doldu.", 404);
            }

            var appointment = new SpaAppointment
            {
                HotelId = session.GuestStay.HotelId,
                GuestStayId = session.GuestStayId,
                ServiceName = request.ServiceName,
                TherapistName = request.TherapistName,
                AppointmentDate = request.Date.Date,
                TimeSlot = request.TimeSlot,
                Price = request.Price,
                CurrencyCode = "TRY",
                Status = "Confirmed",
                CreatedDate = DateTime.Now
            };

            _dbContext.SpaAppointments.Add(appointment);

            var charge = new Charge
            {
                GuestStayId = session.GuestStayId,
                Amount = request.Price,
                CurrencyCode = "TRY",
                Description = $"SPA Rezervasyonu - {request.ServiceName} ({request.TimeSlot})",
                CreatedDate = DateTime.Now,
                IsActive = true
            };
            _dbContext.Charges.Add(charge);

            await _dbContext.SaveChangesAsync(cancellationToken);

            await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Reception(session.GuestStay.HotelId))
                .SendAsync("NotificationReceived", new { Title = "SPA Rezervasyonu", Description = $"{session.GuestStay.Room?.Name ?? "Oda"} misafiri SPA randevusu oluşturdu." }, cancellationToken);

            return new ResponseDto<bool>().Success(true);
        }

        [HttpGet("spa/my-appointments/{sessionToken}")]
        public async Task<ResponseDto<IList<MobileSpaAppointmentResponse>>> GetSpaAppointments(string sessionToken, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: sessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<IList<MobileSpaAppointmentResponse>>().Fail("Misafir oturumu bulunamadı veya süresi doldu.", 404);
            }

            var list = await _dbContext.SpaAppointments
                .Where(x => x.GuestStayId == session.GuestStayId && x.Status == "Confirmed")
                .OrderBy(x => x.AppointmentDate)
                .ThenBy(x => x.TimeSlot)
                .Select(x => new MobileSpaAppointmentResponse
                {
                    Id = x.Id,
                    ServiceName = x.ServiceName,
                    TherapistName = x.TherapistName,
                    AppointmentDate = x.AppointmentDate,
                    TimeSlot = x.TimeSlot,
                    Price = x.Price,
                    CurrencyCode = x.CurrencyCode,
                    Status = x.Status
                })
                .ToListAsync(cancellationToken);

            return new ResponseDto<IList<MobileSpaAppointmentResponse>>().Success(list);
        }

        [HttpPost("pay-folio")]
        public async Task<ResponseDto<bool>> PayFolio(MobileFolioPaymentRequest request, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: request.SessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<bool>().Fail("Misafir oturumu bulunamadı veya süresi doldu.", 404);
            }

            if (request.Amount <= 0)
            {
                return new ResponseDto<bool>().Fail("Geçersiz ödeme tutarı.", 400);
            }

            if (request.PaymentMethod == "OnlineCard")
            {
                var charge = new Charge
                {
                    GuestStayId = session.GuestStayId,
                    Amount = -request.Amount,
                    CurrencyCode = "TRY",
                    Description = $"Online Kredi Kartı Ödemesi (*{request.CardNumber?.Substring(Math.Max(0, (request.CardNumber?.Length ?? 0) - 4))})",
                    CreatedDate = DateTime.Now,
                    IsActive = true
                };
                _dbContext.Charges.Add(charge);
                await _dbContext.SaveChangesAsync(cancellationToken);

                var paymentTx = new PaymentTransaction
                {
                    ChargeId = charge.Id,
                    Amount = request.Amount,
                    CurrencyCode = "TRY",
                    PaymentMethod = "Online Kredi Kartı",
                    PaymentStatus = OrderPaymentStatusEnum.Paid,
                    PaidAt = DateTime.UtcNow,
                    CreatedDate = DateTime.Now,
                    IsActive = true
                };
                _dbContext.PaymentTransactions.Add(paymentTx);
                await _dbContext.SaveChangesAsync(cancellationToken);

                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Reception(session.GuestStay.HotelId))
                    .SendAsync("NotificationReceived", new { Title = "Online Ödeme Alındı", Description = $"{session.GuestStay.Room?.Name ?? "Oda"} misafiri mobil uygulamadan {request.Amount:N2} TRY ödedi." }, cancellationToken);
            }
            else if (request.PaymentMethod == "Lobby")
            {
                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Reception(session.GuestStay.HotelId))
                    .SendAsync("NotificationReceived", new { Title = "Lobi Ödeme Talebi", Description = $"{session.GuestStay.Room?.Name ?? "Oda"} misafiri lobi/resepsiyonda ödeme yapmak istiyor." }, cancellationToken);
            }

            return new ResponseDto<bool>().Success(true);
        }

        [HttpPost("ai-assist")]
        public async Task<ResponseDto<MobileAiResponse>> AskAiAssistant(MobileAiRequest request, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: request.SessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<MobileAiResponse>().Fail("Misafir oturumu bulunamadı veya süresi doldu.", 404);
            }

            var query = (request.Message ?? "").ToLower(new System.Globalization.CultureInfo("tr-TR"));
            string responseText = "";
            string lang = session.LanguageCode.Split('-')[0].ToLower();

            if (query.Contains("hello") || query.Contains("wifi") || query.Contains("pool") || query.Contains("breakfast") || query.Contains("checkout"))
            {
                lang = "en";
            }

            if (lang == "tr")
            {
                if (query.Contains("kahvaltı") || query.Contains("yemek"))
                    responseText = "Açık büfe kahvaltımız her gün sabah 07:00 - 10:30 saatleri arasında Ana Restoranımızda servis edilmektedir.";
                else if (query.Contains("wifi") || query.Contains("internet") || query.Contains("şifre"))
                    responseText = "Otel genelinde ücretsiz Wi-Fi hizmetimiz mevcuttur. Bağlanmak için 'StayZora_Guest' ağını seçip oda numaranız ve doğum yılınız ile giriş yapabilirsiniz.";
                else if (query.Contains("havuz") || query.Contains("plaj") || query.Contains("spa"))
                    responseText = "Açık havuzumuz 08:00 - 20:00 saatleri arasında, SPA ve kapalı havuzumuz ise 09:00 - 22:00 saatleri arasında hizmet vermektedir.";
                else if (query.Contains("çıkış") || query.Contains("check-out") || query.Contains("check out"))
                    responseText = "Oda çıkış saati en geç 12:00'dir. Çıkış işlemlerinizi profil sayfanızdaki 'Mobil Hızlı Çıkış' menüsünden resepsiyona gelmeden kolayca yapabilirsiniz.";
                else
                    responseText = "Merhaba! Size nasıl yardımcı olabilirim? Oda servisi, havuz saatleri, Wi-Fi şifresi veya check-out hakkında sorular sorabilirsiniz.";
            }
            else if (lang == "de")
            {
                if (query.Contains("frühstück") || query.Contains("essen"))
                    responseText = "Unser Frühstücksbuffet wird täglich von 07:00 bis 10:30 Uhr im Hauptrestaurant serviert.";
                else if (query.Contains("wifi") || query.Contains("internet") || query.Contains("passwort"))
                    responseText = "Kostenloses Wi-Fi ist im gesamten Hotel verfügbar. Wählen Sie das Netzwerk 'StayZora_Guest' und melden Sie sich mit Ihrer Zimmernummer und Ihrem Geburtsjahr an.";
                else if (query.Contains("pool") || query.Contains("spa"))
                    responseText = "Unser Außenpool ist von 08:00 bis 20:00 Uhr geöffnet, während SPA und Innenpool von 09:00 bis 22:00 Uhr zur Verfügung stehen.";
                else if (query.Contains("check-out") || query.Contains("abfahrt"))
                    responseText = "Die Check-out-Zeit ist bis spätestens 12:00 Uhr. Sie können Ihren Check-out bequem über das Menü 'Mobile Quick Check-out' auf Ihrer Profilseite durchführen.";
                else
                    responseText = "Hallo! Wie kann ich Ihnen helfen? Sie können Fragen zu Zimmerservice, Poolzeiten, Wi-Fi-Passwort oder Check-out stellen.";
            }
            else if (lang == "fr")
            {
                if (query.Contains("petit") || query.Contains("déjeuner") || query.Contains("manger"))
                    responseText = "Notre petit-déjeuner buffet est servi tous les jours de 07h00 à 10h30 dans notre restaurant principal.";
                else if (query.Contains("wifi") || query.Contains("internet") || query.Contains("mot de passe"))
                    responseText = "Une connexion Wi-Fi gratuite est disponible dans tout l'hôtel. Sélectionnez le réseau 'StayZora_Guest' et connectez-vous avec votre numéro de chambre et votre année de naissance.";
                else if (query.Contains("piscine") || query.Contains("spa"))
                    responseText = "Notre piscine extérieure est ouverte de 08h00 à 20h00, et le SPA ainsi que la piscine intérieure sont ouverts de 09h00 à 22h00.";
                else if (query.Contains("départ") || query.Contains("check-out"))
                    responseText = "L'heure de départ est fixée à 12h00 au plus tard. Vous pouvez effectuer votre départ facilement depuis le menu 'Mobile Quick Check-out' sur votre profil.";
                else
                    responseText = "Bonjour ! Comment puis-je vous aider ? Posez-moi des questions sur le service d'étage, les horaires de piscine, le Wi-Fi ou le départ.";
            }
            else if (lang == "es")
            {
                if (query.Contains("desayuno") || query.Contains("comer"))
                    responseText = "Nuestro desayuno buffet se sirve todos los días de 07:00 a 10:30 en nuestro restaurante principal.";
                else if (query.Contains("wifi") || query.Contains("internet") || query.Contains("contraseña"))
                    responseText = "Hay Wi-Fi gratuito disponible en todo el hotel. Seleccione la red 'StayZora_Guest' e inicie sesión con su número de habitación y año de nacimiento.";
                else if (query.Contains("piscina") || query.Contains("spa"))
                    responseText = "Nuestra piscina al aire libre está abierta de 08:00 a 20:00, y el SPA y la piscina cubierta están abiertos de 09:00 a 22:00.";
                else if (query.Contains("salida") || query.Contains("check-out"))
                    responseText = "La hora de salida es a las 12:00 a más tardar. Puede realizar su salida fácilmente desde el menú 'Mobile Quick Check-out' en su perfil.";
                else
                    responseText = "¡Hola! ¿Cómo puedo ayudarte? Puedes preguntarme sobre servicio de habitaciones, horarios de piscina, Wi-Fi o salida.";
            }
            else if (lang == "ru")
            {
                if (query.Contains("завтрак") || query.Contains("еда"))
                    responseText = "Наш завтрак 'шведский стол' подается ежедневно с 07:00 до 10:30 в главном ресторане.";
                else if (query.Contains("wi-fi") || query.Contains("интернет") || query.Contains("пароль"))
                    responseText = "Бесплатный Wi-Fi доступен на всей территории отеля. Выберите сеть 'StayZora_Guest' и войдите, указав номер комнаты и год рождения.";
                else if (query.Contains("бассейн") || query.Contains("спа"))
                    responseText = "Наш открытый бассейн работает с 08:00 до 20:00, а спа-центр и крытый бассейн открыты с 09:00 до 22:00.";
                else if (query.Contains("выезд") || query.Contains("check-out"))
                    responseText = "Время выезда — не позднее 12:00. Вы можете легко выписаться с помощью меню 'Mobile Quick Check-out' в своем профиле.";
                else
                    responseText = "Привет! Чем я могу вам помочь? Вы можете спросить о доставке еды в номер, времени работы бассейна, пароле от Wi-Fi или выезде.";
            }
            else if (lang == "ar")
            {
                if (query.Contains("فطور") || query.Contains("أكل"))
                    responseText = "يتم تقديم بوفيه الإفطار يوميًا من الساعة 07:00 حتى 10:30 صباحًا في مطعمنا الرئيسي.";
                else if (query.Contains("واي") || query.Contains("إنترنت") || query.Contains("كلمة"))
                    responseText = "خدمة الواي فاي المجانية متوفرة في جميع أنحاء الفندق. اختر شبكة 'StayZora_Guest' وسجل الدخول باستخدام رقم غرفتك وسنة ميلادك.";
                else if (query.Contains("مسبح") || query.Contains("سبا"))
                    responseText = "المسبح الخارجي مفتوح من 08:00 صباحًا حتى 20:00 مساءً، بينما يعمل السبا والمسبح الداخلي من 09:00 صباحًا hasta 22:00 مساءً.";
                else if (query.Contains("خروج") || query.Contains("مغادرة"))
                    responseText = "وقت تسجيل المغادرة هو 12:00 ظهرًا على أقصى تقدير. يمكنك تسجيل المغادرة بسهولة من قائمة 'خروج الهاتف المحمول السريع' في ملفك الشخصي.";
                else
                    responseText = "مرحبًا! كيف يمكنني مساعدتك؟ يمكنك الاستفسار عن خدمة الغرف، مواعيد المسبح، كلمة مرور الواي فاي، أو تسجيل المغادرة.";
            }
            else
            {
                if (query.Contains("breakfast") || query.Contains("food") || query.Contains("eat"))
                    responseText = "Our buffet breakfast is served daily from 07:00 to 10:30 in our Main Restaurant.";
                else if (query.Contains("wifi") || query.Contains("internet") || query.Contains("password") || query.Contains("code"))
                    responseText = "Free Wi-Fi is available hotel-wide. Select 'StayZora_Guest' network and log in using your room number and birth year.";
                else if (query.Contains("pool") || query.Contains("beach") || query.Contains("spa"))
                    responseText = "Our outdoor pool is open from 08:00 to 20:00, while the SPA and indoor pool are open from 09:00 to 22:00.";
                else if (query.Contains("checkout") || query.Contains("check-out") || query.Contains("leave"))
                    responseText = "Checkout time is 12:00 PM at the latest. You can complete your checkout easily via the 'Mobile Quick Check-out' menu on your profile page.";
                else
                    responseText = "Hello! How can I assist you? You can ask me about room service, pool hours, Wi-Fi password, or checkout.";
            }

            return new ResponseDto<MobileAiResponse>().Success(new MobileAiResponse { Response = responseText });
        }

        [HttpGet("service-request/{serviceRequestId:int}/messages/{sessionToken}")]
        public async Task<ResponseDto<IList<MobileChatMessageResponse>>> GetServiceRequestMessages(int serviceRequestId, string sessionToken, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: sessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<IList<MobileChatMessageResponse>>().Fail("Misafir oturumu bulunamadı veya süresi doldu.", 404);
            }

            var serviceRequest = await _dbContext.ServiceRequests
                .FirstOrDefaultAsync(x => x.Id == serviceRequestId && x.GuestStayId == session.GuestStayId && !x.IsDeleted, cancellationToken);

            if (serviceRequest is null)
            {
                return new ResponseDto<IList<MobileChatMessageResponse>>().Fail("Servis talebi bulunamadı.", 404);
            }

            var queryResponse = await _mediator.Send(new WorigoApp.Application.Features.ServiceRequestMessages.Queries.GetServiceRequestMessages.GetServiceRequestMessagesQueryRequest
            {
                ServiceRequestId = serviceRequestId
            }, cancellationToken);

            if (!queryResponse.IsSuccess || queryResponse.Data is null)
            {
                return new ResponseDto<IList<MobileChatMessageResponse>>().Fail(queryResponse.Errors ?? new List<string> { "Mesajlar yüklenemedi." }, queryResponse.StatusCode);
            }

            var guestName = session.Customer is not null ? $"{session.Customer.Name} {session.Customer.SurName}".Trim() : "Misafir";
            var employeeName = serviceRequest.AssignedEmployeeId.HasValue 
                ? await _dbContext.Employee.Where(e => e.Id == serviceRequest.AssignedEmployeeId.Value).Select(e => $"{e.Name} {e.Surname}").FirstOrDefaultAsync(cancellationToken) 
                : "Personel";

            var mappedList = queryResponse.Data.Select(x => new MobileChatMessageResponse
            {
                Id = x.Id,
                ServiceRequestId = serviceRequestId,
                SenderType = x.SenderType.ToString(),
                OriginalText = x.OriginalText,
                TranslatedText = x.TranslatedText,
                SenderName = x.SenderType == MessageSenderTypeEnum.Customer ? guestName : employeeName ?? "Personel",
                SentAt = x.SentAt
            }).ToList();

            return new ResponseDto<IList<MobileChatMessageResponse>>().Success(mappedList);
        }

        [HttpPost("service-request/message")]
        public async Task<ResponseDto<bool>> SendServiceRequestMessage(MobileSendChatMessageRequest request, CancellationToken cancellationToken)
        {
            var session = await FindActiveSessionAsync(qrCodeToken: null, sessionToken: request.SessionToken, cancellationToken);
            if (session is null)
            {
                return new ResponseDto<bool>().Fail("Misafir oturumu bulunamadı veya süresi doldu.", 404);
            }

            var serviceRequest = await _dbContext.ServiceRequests
                .FirstOrDefaultAsync(x => x.Id == request.ServiceRequestId && x.GuestStayId == session.GuestStayId && !x.IsDeleted, cancellationToken);

            if (serviceRequest is null)
            {
                return new ResponseDto<bool>().Fail("Servis talebi bulunamadı.", 404);
            }

            var commandResponse = await _mediator.Send(new WorigoApp.Application.Features.ServiceRequestMessages.Commands.CreateServiceRequestMessage.CreateServiceRequestMessageCommandRequest
            {
                ServiceRequestId = request.ServiceRequestId,
                SenderUserId = null,
                SenderType = MessageSenderTypeEnum.Customer,
                OriginalLanguageCode = string.IsNullOrWhiteSpace(session.LanguageCode) ? "tr-TR" : session.LanguageCode,
                OriginalText = request.Message,
                MessageType = "Text"
            }, cancellationToken);

            if (!commandResponse.IsSuccess || commandResponse.Data is null)
            {
                return new ResponseDto<bool>().Fail(commandResponse.Errors ?? new List<string> { "Mesaj gönderilemedi." }, commandResponse.StatusCode);
            }

            // Broadcast message via SignalR Group (ServiceRequest group)
            var guestName = session.Customer is not null ? $"{session.Customer.Name} {session.Customer.SurName}".Trim() : "Misafir";
            var broadcastData = new MobileChatMessageResponse
            {
                Id = commandResponse.Data.Id,
                ServiceRequestId = commandResponse.Data.ServiceRequestId,
                SenderType = commandResponse.Data.SenderType,
                OriginalText = commandResponse.Data.OriginalText,
                TranslatedText = commandResponse.Data.TranslatedText,
                SenderName = guestName,
                SentAt = commandResponse.Data.SentAt
            };

            await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.ServiceRequest(request.ServiceRequestId))
                .SendAsync("ServiceRequestMessageCreated", broadcastData, cancellationToken);

            // Also notify reception and hotel groups of activity
            await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Reception(serviceRequest.HotelId))
                .SendAsync("ServiceRequestUpdated", new { Id = serviceRequest.Id, Status = (int)serviceRequest.Status }, cancellationToken);

            return new ResponseDto<bool>().Success(true);
        }
    }

    public class MobileFolioResponse
    {
        public int GuestStayId { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public string GuestName { get; set; } = string.Empty;
        public decimal TotalCharges { get; set; }
        public decimal TotalPayments { get; set; }
        public decimal RemainingBalance { get; set; }
        public string CurrencyCode { get; set; } = "TRY";
        public List<MobileFolioItemDto> Items { get; set; } = new();
    }

    public class MobileFolioItemDto
    {
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; } = "TRY";
        public DateTime Date { get; set; }
        public bool IsPayment { get; set; }
    }

    public class MobileCheckoutRequest
    {
        public string SessionToken { get; set; } = string.Empty;
        public bool Force { get; set; }
    }

    public class MobileCheckoutResultDto
    {
        public bool Success { get; set; }
        public string? WarningCode { get; set; }
        public string Message { get; set; } = string.Empty;
    }

    public class MobileGuestQrLoginRequest
    {
        public string QrCodeToken { get; set; } = string.Empty;
    }

    public class MobileGuestUpdateLanguageRequest
    {
        public string SessionToken { get; set; } = string.Empty;
        public string LanguageCode { get; set; } = "tr-TR";
    }

    public class MobileGuestCreateServiceRequest
    {
        public string SessionToken { get; set; } = string.Empty;
        public ServicesEnum ServiceType { get; set; } = ServicesEnum.TechnicalNeed;
        public int? ServiceItemId { get; set; }
        public int? ServiceDefinitionId { get; set; }
        public int? ConversationId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public ServiceRequestPriorityEnum Priority { get; set; } = ServiceRequestPriorityEnum.Normal;
        public IList<ServiceRequestFieldValueDto> FieldValues { get; set; } = new List<ServiceRequestFieldValueDto>();
        public IList<ServiceRequestItemDto> Items { get; set; } = new List<ServiceRequestItemDto>();
    }

    public class MobileGuestStartFlowRequest
    {
        public string SessionToken { get; set; } = string.Empty;
        public int? ServiceCategoryId { get; set; }
        public int? ServiceDefinitionId { get; set; }
        public string FlowType { get; set; } = string.Empty;
        public string CurrentStep { get; set; } = "start";
        public string StateJson { get; set; } = "{}";
        public string? Subject { get; set; }
        public string OpeningMessage { get; set; } = string.Empty;
        public ConversationMessageTypeEnum OpeningMessageType { get; set; } = ConversationMessageTypeEnum.OptionList;
        public string? OpeningPayloadJson { get; set; }
    }

    public class MobileGuestQuickActionResponse
    {
        public int? ServiceCategoryId { get; set; }
        public int? ServiceDefinitionId { get; set; }
        public string ServiceType { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public string? IconKey { get; set; }
        public bool ShowOnHome { get; set; }
        public bool IsPopular { get; set; }
        public int? HomeDisplayOrder { get; set; }
        public string? PreviewImageUrl { get; set; }
        public int DisplayOrder { get; set; }
        public ConversationMessageTypeEnum OpeningMessageType { get; set; }
        public string OpeningMessage { get; set; } = string.Empty;
        public string? OpeningPayloadJson { get; set; }
        public int ItemCount { get; set; }
    }

    public class MobileGuestServiceCategoryResponse
    {
        public int ServiceCategoryId { get; set; }
        public string DisplayName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? IconKey { get; set; }
        public string? IconUrl { get; set; }
        public int DisplayOrder { get; set; }
        public bool ShowOnHome { get; set; }
        public bool IsPopular { get; set; }
        public int? HomeDisplayOrder { get; set; }
        public int ItemCount { get; set; }
        public bool ContainsChargeableItems { get; set; }
        public string? PreviewImageUrl { get; set; }
    }

    public class MobileGuestAnnouncementResponse
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public string Type { get; set; } = string.Empty;
        public DateTime StartAt { get; set; }
        public DateTime? EndAt { get; set; }
        public string? Location { get; set; }
        public bool IsPinned { get; set; }
    }

    public class MobileGuestSessionResponse
    {
        public int GuestSessionId { get; set; }
        public int GuestStayId { get; set; }
        public int CustomerId { get; set; }
        public int HotelId { get; set; }
        public string HotelName { get; set; } = string.Empty;
        public string RoomName { get; set; } = string.Empty;
        public string GuestName { get; set; } = string.Empty;
        public string SessionToken { get; set; } = string.Empty;
        public string LanguageCode { get; set; } = "tr-TR";
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }

    public class MobileRoomIotResponse
    {
        public double TargetTemperature { get; set; }
        public int LightsIntensity { get; set; }
        public bool AreCurtainsOpen { get; set; }
    }

    public class MobileRoomIotUpdateRequest
    {
        public string SessionToken { get; set; } = string.Empty;
        public double TargetTemperature { get; set; }
        public int LightsIntensity { get; set; }
        public bool AreCurtainsOpen { get; set; }
    }

    public class MobileSpaServiceResponse
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string CurrencyCode { get; set; } = "TRY";
        public string Duration { get; set; } = string.Empty;
    }

    public class MobileSpaBookRequest
    {
        public string SessionToken { get; set; } = string.Empty;
        public string ServiceName { get; set; } = string.Empty;
        public string TherapistName { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string TimeSlot { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }

    public class MobileSpaAppointmentResponse
    {
        public int Id { get; set; }
        public string ServiceName { get; set; } = string.Empty;
        public string TherapistName { get; set; } = string.Empty;
        public DateTime AppointmentDate { get; set; }
        public string TimeSlot { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string CurrencyCode { get; set; } = "TRY";
        public string Status { get; set; } = "Confirmed";
    }

    public class MobileFolioPaymentRequest
    {
        public string SessionToken { get; set; } = string.Empty;
        public string PaymentMethod { get; set; } = "OnlineCard";
        public string? CardNumber { get; set; }
        public string? CardHolder { get; set; }
        public string? ExpiryDate { get; set; }
        public string? Cvv { get; set; }
        public decimal Amount { get; set; }
    }

    public class MobileAiRequest
    {
        public string SessionToken { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
    }

    public class MobileAiResponse
    {
        public string Response { get; set; } = string.Empty;
    }

    public class MobileSendChatMessageRequest
    {
        public string SessionToken { get; set; } = string.Empty;
        public int ServiceRequestId { get; set; }
        public string Message { get; set; } = string.Empty;
    }

    public class MobileChatMessageResponse
    {
        public int Id { get; set; }
        public int ServiceRequestId { get; set; }
        public string SenderType { get; set; } = string.Empty;
        public string OriginalText { get; set; } = string.Empty;
        public string? TranslatedText { get; set; }
        public string SenderName { get; set; } = string.Empty;
        public DateTime SentAt { get; set; }
    }
}
