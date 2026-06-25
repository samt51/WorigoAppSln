using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using MediatR;
using System.Security.Claims;
using WorigoApp.Api.Hubs;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.ServiceRequestMessages.Commands.CreateServiceRequestMessage;
using WorigoApp.Application.Features.ServiceRequestMessages.Queries.GetServiceRequestMessages;
using WorigoApp.Application.Features.Auth.Dtos;
using WorigoApp.Application.Helpers;
using WorigoApp.Application.Interfaces.Auth.Jwt.Tokens;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;
using WorigoApp.Persistence.Context;

namespace WorigoApp.Api.Controllers.Mobile
{
    /// <summary>
    /// MobileStaffController sınıfını temsil eder.
    /// </summary>
[ApiController]
    [Route("api/mobile/staff")]
    public class MobileStaffController : ControllerBase
    {
        private static readonly HashSet<string> BlockedMobileRoles = new(StringComparer.OrdinalIgnoreCase)
        {
            "Customer",
            "SystemAdmin"
        };

        private readonly AppDbContext _dbContext;
        private readonly ITokenService _tokenService;
        private readonly IHubContext<HotelOperationsHub> _hubContext;
        private readonly IMediator _mediator;
/// <summary>
/// MobileStaffController sınıfının yeni bir örneğini başlatır.
/// </summary>
public MobileStaffController(AppDbContext dbContext, ITokenService tokenService, IHubContext<HotelOperationsHub> hubContext, IMediator mediator)
        {
            _dbContext = dbContext;
            _tokenService = tokenService;
            _hubContext = hubContext;
            _mediator = mediator;
        }

        /// <summary>
        /// Login işlemini gerçekleştirir.
        /// </summary>
[AllowAnonymous]
        [HttpPost("login")]
        [HttpPost("/api/personel/login")]
        [HttpPost("/api/personnel/login")]
        [HttpPost("/api/employee/login")]
        [HttpPost("/api/staff/login")]
        public async Task<ResponseDto<MobileStaffLoginResponse>> Login(
            [FromBody] MobileStaffLoginRequest request,
            CancellationToken cancellationToken)
        {
            var email = request.Email?.Trim() ?? string.Empty;
            var password = request.Password ?? string.Empty;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                return new ResponseDto<MobileStaffLoginResponse>()
                    .Fail("E-posta ve sifre zorunludur.", 400);
            }

            var user = await QueryStaffUser()
                .FirstOrDefaultAsync(x =>
                    x.Email == email &&
                    x.Password == PasswordHash.HashPassword(password),
                    cancellationToken);

            if (user is null)
            {
                return new ResponseDto<MobileStaffLoginResponse>()
                    .Fail("E-posta veya sifre hatali.", 401);
            }

            var roleName = user.Role?.Name ?? string.Empty;
            if (!IsMobileStaffRole(roleName))
            {
                return new ResponseDto<MobileStaffLoginResponse>()
                    .Fail("Bu kullanici mobil personel uygulamasina giris yapamaz.", 403);
            }

            if (user.IsLocked || !user.IsActive || user.IsDeleted)
            {
                return new ResponseDto<MobileStaffLoginResponse>()
                    .Fail("Kullanici hesabi aktif degil.", 403);
            }

            if (user.Employee is not null && (!user.Employee.Status || user.Employee.IsDeleted || !user.Employee.IsActive))
            {
                return new ResponseDto<MobileStaffLoginResponse>()
                    .Fail("Personel kaydi aktif degil.", 403);
            }

            user.LastLoginAt = DateTime.UtcNow;
            user.FailedLoginCount = 0;
            user.ModifyDate = DateTime.Now;
            await _dbContext.SaveChangesAsync(cancellationToken);

            var token = await _tokenService.GenerateToken(new GenerateTokenRequest(
                user.Id,
                user.Email,
                roleName,
                user.RoleId));

            return new ResponseDto<MobileStaffLoginResponse>().Success(new MobileStaffLoginResponse
            {
                Token = token.Token,
                TokenExpireDate = token.TokenExpireDate,
                Staff = BuildStaffProfile(user),
                Navigation = BuildNavigation(roleName, user.Employee),
                ApiScopes = BuildApiScopes(roleName, user.Employee),
                StartupRoute = ResolveStartupRoute(roleName, user.Employee),
                Realtime = BuildRealtime(user)
            });
        }

        /// <summary>
        /// Me işlemini gerçekleştirir.
        /// </summary>
[Authorize(Roles = "HotelAdmin,Management,DepartmentManager,Employee")]
        [HttpGet("me")]
        public async Task<ResponseDto<MobileStaffMeResponse>> Me(CancellationToken cancellationToken)
        {
            var userId = ResolveUserId();
            if (!userId.HasValue)
            {
                return new ResponseDto<MobileStaffMeResponse>().Fail("Token kullanici bilgisi tasimiyor.", 401);
            }

            var user = await QueryStaffUser()
                .FirstOrDefaultAsync(x => x.Id == userId.Value, cancellationToken);

            if (user is null)
            {
                return new ResponseDto<MobileStaffMeResponse>().Fail("Kullanici bulunamadi.", 404);
            }

            var roleName = user.Role?.Name ?? string.Empty;
            if (!IsMobileStaffRole(roleName))
            {
                return new ResponseDto<MobileStaffMeResponse>()
                    .Fail("Bu kullanici mobil personel uygulamasina giris yapamaz.", 403);
            }

            return new ResponseDto<MobileStaffMeResponse>().Success(new MobileStaffMeResponse
            {
                Staff = BuildStaffProfile(user),
                Navigation = BuildNavigation(roleName, user.Employee),
                ApiScopes = BuildApiScopes(roleName, user.Employee),
                StartupRoute = ResolveStartupRoute(roleName, user.Employee),
                Realtime = BuildRealtime(user)
            });
        }

        /// <summary>
        /// RegisterDeviceToken işlemini gerçekleştirir.
        /// </summary>
[Authorize(Roles = "HotelAdmin,Management,DepartmentManager,Employee")]
        [HttpPost("device-token")]
        public async Task<ResponseDto<bool>> RegisterDeviceToken(
            [FromBody] MobileStaffDeviceTokenRequest request,
            CancellationToken cancellationToken)
        {
            var user = await ResolveCurrentStaffUserAsync(cancellationToken);
            var employee = user?.Employee;
            if (user is null || employee is null)
            {
                return new ResponseDto<bool>().Fail(false, "Personel oturumu bulunamadi.", 401);
            }

            if (string.IsNullOrWhiteSpace(request.Token))
            {
                return new ResponseDto<bool>().Fail(false, "Firebase token zorunludur.", 400);
            }

            var token = request.Token.Trim();
            var now = DateTime.UtcNow;

            var existingToken = await _dbContext.EmployeeDeviceTokens
                .FirstOrDefaultAsync(x => x.Token == token, cancellationToken);

            if (existingToken is null)
            {
                await _dbContext.EmployeeDeviceTokens.AddAsync(new EmployeeDeviceToken
                {
                    UserId = user.Id,
                    EmployeeId = employee.Id,
                    Token = token,
                    Platform = string.IsNullOrWhiteSpace(request.Platform) ? "unknown" : request.Platform.Trim(),
                    DeviceId = request.DeviceId,
                    LastSeenAt = now,
                    CreatedDate = now,
                    ModifyDate = now,
                    IsActive = true
                }, cancellationToken);
            }
            else
            {
                existingToken.UserId = user.Id;
                existingToken.EmployeeId = employee.Id;
                existingToken.Platform = string.IsNullOrWhiteSpace(request.Platform) ? existingToken.Platform : request.Platform.Trim();
                existingToken.DeviceId = request.DeviceId ?? existingToken.DeviceId;
                existingToken.LastSeenAt = now;
                existingToken.ModifyDate = now;
                existingToken.IsActive = true;
                existingToken.IsDeleted = false;
            }

            await _dbContext.SaveChangesAsync(cancellationToken);
            return new ResponseDto<bool>().Success(true);
        }

        /// <summary>
        /// GetWorkItems işlemini gerçekleştirir.
        /// </summary>
[Authorize(Roles = "HotelAdmin,Management,DepartmentManager,Employee")]
        [HttpGet("work-items")]
        public async Task<ResponseDto<IList<MobileStaffWorkItemResponse>>> GetWorkItems(CancellationToken cancellationToken)
        {
            var user = await ResolveCurrentStaffUserAsync(cancellationToken);
            if (user is null)
            {
                return new ResponseDto<IList<MobileStaffWorkItemResponse>>().Fail("Personel oturumu bulunamadi.", 401);
            }

            var employee = user.Employee;
            if (employee is null)
            {
                return new ResponseDto<IList<MobileStaffWorkItemResponse>>().Fail("Personel kaydi bulunamadi.", 404);
            }

            var roleName = user.Role?.Name ?? string.Empty;
            var query = QueryMobileWorkItems();

            bool isReceptionist = employee.EmployeeType?.Name == "Resepsiyonist" || 
                                  employee.EmployeeType?.DepartmentId == 1;

            if (isReceptionist || RoleEquals(roleName, "HotelAdmin") || RoleEquals(roleName, "Management"))
            {
                // Receptionists and admins see all requests for the hotel
            }
            else if (RoleEquals(roleName, "DepartmentManager") && employee.EmployeeType?.DepartmentId is not null)
            {
                var departmentId = employee.EmployeeType.DepartmentId;
                query = query.Where(x => x.DepartmentId == departmentId || x.AssignedEmployeeId == employee.Id);
            }
            else
            {
                var departmentId = employee.EmployeeType?.DepartmentId;
                query = query.Where(x =>
                    x.AssignedEmployeeId == employee.Id ||
                    (!x.AssignedEmployeeId.HasValue &&
                     departmentId.HasValue &&
                     x.DepartmentId == departmentId.Value));
            }

            if (employee.HotelId > 0)
            {
                query = query.Where(x => x.HotelId == employee.HotelId);
            }

            var items = await query
                .OrderByDescending(x => x.Priority == ServiceRequestPriorityEnum.Critical || x.Priority == ServiceRequestPriorityEnum.High)
                .ThenBy(x => x.DueAt)
                .ThenBy(x => x.RequestedAt)
                .Take(100)
                .ToListAsync(cancellationToken);

            return new ResponseDto<IList<MobileStaffWorkItemResponse>>().Success(items.Select(MapWorkItem).ToList());
        }

        /// <summary>
        /// GetWorkItem işlemini gerçekleştirir.
        /// </summary>
[Authorize(Roles = "HotelAdmin,Management,DepartmentManager,Employee")]
        [HttpGet("work-items/{id:int}")]
        public async Task<ResponseDto<MobileStaffWorkItemResponse>> GetWorkItem(int id, CancellationToken cancellationToken)
        {
            var serviceRequest = await QueryMobileWorkItems().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if (serviceRequest is null)
            {
                return new ResponseDto<MobileStaffWorkItemResponse>().Fail("Is bulunamadi.", 404);
            }

            if (!await CanAccessWorkItemAsync(serviceRequest, cancellationToken))
            {
                return new ResponseDto<MobileStaffWorkItemResponse>().Fail("Bu ise erisim yetkiniz yok.", 403);
            }

            return new ResponseDto<MobileStaffWorkItemResponse>().Success(MapWorkItem(serviceRequest));
        }

        /// <summary>
        /// UpdateWorkStatus işlemini gerçekleştirir.
        /// </summary>
[Authorize(Roles = "HotelAdmin,Management,DepartmentManager,Employee")]
        [HttpPost("work-items/{id:int}/status")]
        public async Task<ResponseDto<MobileStaffWorkStatusResponse>> UpdateWorkStatus(
            int id,
            [FromBody] MobileStaffUpdateWorkStatusRequest request,
            CancellationToken cancellationToken)
        {
            var serviceRequest = await QueryMobileWorkItems(enableTracking: true)
                .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

            if (serviceRequest is null)
            {
                return new ResponseDto<MobileStaffWorkStatusResponse>().Fail("Is bulunamadi.", 404);
            }

            if (!await CanAccessWorkItemAsync(serviceRequest, cancellationToken))
            {
                return new ResponseDto<MobileStaffWorkStatusResponse>().Fail("Bu isi guncelleme yetkiniz yok.", 403);
            }

            if (!TryResolveStatus(request.StatusKey, out var newStatus))
            {
                return new ResponseDto<MobileStaffWorkStatusResponse>().Fail("Gecersiz durum.", 400);
            }

            if (string.Equals(request.StatusKey, "incomplete", StringComparison.OrdinalIgnoreCase) &&
                string.IsNullOrWhiteSpace(request.IncompleteReason))
            {
                return new ResponseDto<MobileStaffWorkStatusResponse>().Fail("Tamamlanamadi sebebi zorunludur.", 400);
            }

            var userId = ResolveUserId();
            var now = DateTime.UtcNow;
            var oldStatus = serviceRequest.Status;
            serviceRequest.Status = newStatus;

            if (newStatus == ServiceRequestStatusEnum.InProgress)
            {
                serviceRequest.StartedAt ??= now;
            }
            else if (newStatus == ServiceRequestStatusEnum.Completed)
            {
                serviceRequest.CompletedAt = now;
                serviceRequest.ResolutionNote = request.Note;
            }
            else if (newStatus == ServiceRequestStatusEnum.Cancelled)
            {
                serviceRequest.ResolutionNote = $"{request.IncompleteReason} {request.Note}".Trim();
            }

            _dbContext.ServiceRequestHistories.Add(new ServiceRequestHistory
            {
                ServiceRequestId = serviceRequest.Id,
                OldStatus = oldStatus,
                NewStatus = newStatus,
                ChangedByUserId = userId,
                ChangedAt = now,
                Note = string.IsNullOrWhiteSpace(request.IncompleteReason)
                    ? request.Note
                    : $"{request.IncompleteReason} | {request.Note}".Trim(' ', '|')
            });

            await _dbContext.SaveChangesAsync(cancellationToken);
            await BroadcastWorkItemAsync(serviceRequest, "ServiceRequestUpdated", cancellationToken);

            if (newStatus == ServiceRequestStatusEnum.Completed)
            {
                await BroadcastWorkItemAsync(serviceRequest, "ServiceRequestCompleted", cancellationToken);
            }
            else if (newStatus == ServiceRequestStatusEnum.Cancelled)
            {
                await BroadcastWorkItemAsync(serviceRequest, "ServiceRequestIncomplete", cancellationToken);
            }

            return new ResponseDto<MobileStaffWorkStatusResponse>().Success(new MobileStaffWorkStatusResponse
            {
                Id = serviceRequest.Id,
                Status = ResolveStatusDisplayName(serviceRequest.Status),
                StatusKey = ResolveStatusKey(serviceRequest.Status),
                StartedAt = serviceRequest.StartedAt,
                CompletedAt = serviceRequest.CompletedAt
            });
        }

        /// <summary>
        /// UpdateAvailability işlemini gerçekleştirir.
        /// </summary>
[Authorize(Roles = "HotelAdmin,Management,DepartmentManager,Employee")]
        [HttpPost("availability")]
        public async Task<ResponseDto<MobileStaffAvailabilityResponse>> UpdateAvailability(
            [FromBody] MobileStaffUpdateAvailabilityRequest request,
            CancellationToken cancellationToken)
        {
            var user = await ResolveCurrentStaffUserAsync(cancellationToken);
            var employee = user?.Employee;
            if (employee is null)
            {
                return new ResponseDto<MobileStaffAvailabilityResponse>().Fail("Personel kaydi bulunamadi.", 404);
            }

            var status = string.IsNullOrWhiteSpace(request.Status) ? "Müsait" : request.Status.Trim();
            employee.IsAvailableForTask = status.Equals("Müsait", StringComparison.OrdinalIgnoreCase);
            employee.ModifyDate = DateTime.Now;
            await _dbContext.SaveChangesAsync(cancellationToken);

            var response = new MobileStaffAvailabilityResponse
            {
                EmployeeId = employee.Id,
                Status = status,
                IsAvailableForTask = employee.IsAvailableForTask
            };

            if (employee.HotelId is > 0)
            {
                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Hotel(employee.HotelId.Value))
                    .SendAsync("StaffAvailabilityChanged", response, cancellationToken);
                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Reception(employee.HotelId.Value))
                    .SendAsync("StaffAvailabilityChanged", response, cancellationToken);
            }

            await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Employee(employee.Id))
                .SendAsync("StaffAvailabilityChanged", response, cancellationToken);

            return new ResponseDto<MobileStaffAvailabilityResponse>().Success(response);
        }

        /// <summary>
        /// VerifyRoomQr işlemini gerçekleştirir.
        /// </summary>
[Authorize(Roles = "HotelAdmin,Management,DepartmentManager,Employee")]
        [HttpPost("work-items/{id:int}/room-qr-verify")]
        public async Task<ResponseDto<MobileStaffQrVerifyResponse>> VerifyRoomQr(
            int id,
            [FromBody] MobileStaffVerifyRoomQrRequest request,
            CancellationToken cancellationToken)
        {
            var serviceRequest = await QueryMobileWorkItems().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if (serviceRequest is null)
            {
                return new ResponseDto<MobileStaffQrVerifyResponse>().Fail("Is bulunamadi.", 404);
            }

            if (!await CanAccessWorkItemAsync(serviceRequest, cancellationToken))
            {
                return new ResponseDto<MobileStaffQrVerifyResponse>().Fail("Bu ise erisim yetkiniz yok.", 403);
            }

            var roomName = serviceRequest.Room?.Name ?? serviceRequest.RoomId?.ToString() ?? string.Empty;
            var qr = request.RoomQrCode ?? string.Empty;
            var verified = !string.IsNullOrWhiteSpace(roomName) &&
                           qr.Contains(roomName, StringComparison.OrdinalIgnoreCase);

            var response = new MobileStaffQrVerifyResponse
            {
                WorkItemId = id,
                IsVerified = verified,
                Message = verified ? "Oda dogrulandi." : "Oda QR kodu bu is ile eslesmedi."
            };

            return verified
                ? new ResponseDto<MobileStaffQrVerifyResponse>().Success(response)
                : new ResponseDto<MobileStaffQrVerifyResponse>().Fail(response, "Oda dogrulanamadi.", 400);
        }

        /// <summary>
        /// AddPhotoProof işlemini gerçekleştirir.
        /// </summary>
[Authorize(Roles = "HotelAdmin,Management,DepartmentManager,Employee")]
        [HttpPost("work-items/{id:int}/photo-proof")]
        public async Task<ResponseDto<MobileStaffPhotoProofResponse>> AddPhotoProof(
            int id,
            [FromBody] MobileStaffPhotoProofRequest request,
            CancellationToken cancellationToken)
        {
            var serviceRequest = await QueryMobileWorkItems(enableTracking: true).FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if (serviceRequest is null)
            {
                return new ResponseDto<MobileStaffPhotoProofResponse>().Fail("Is bulunamadi.", 404);
            }

            if (!await CanAccessWorkItemAsync(serviceRequest, cancellationToken))
            {
                return new ResponseDto<MobileStaffPhotoProofResponse>().Fail("Bu ise erisim yetkiniz yok.", 403);
            }

            var now = DateTime.UtcNow;
            _dbContext.ServiceRequestHistories.Add(new ServiceRequestHistory
            {
                ServiceRequestId = serviceRequest.Id,
                OldStatus = serviceRequest.Status,
                NewStatus = serviceRequest.Status,
                ChangedByUserId = ResolveUserId(),
                ChangedAt = now,
                Note = $"Foto proof: {request.PhotoType}. {request.Note}".Trim()
            });

            await _dbContext.SaveChangesAsync(cancellationToken);
            await BroadcastWorkItemAsync(serviceRequest, "ServiceRequestPhotoAdded", cancellationToken);

            return new ResponseDto<MobileStaffPhotoProofResponse>().Success(new MobileStaffPhotoProofResponse
            {
                WorkItemId = id,
                PhotoType = request.PhotoType,
                UploadedAt = now
            });
        }

        /// <summary>
        /// GetWorkItemMessages işlemini gerçekleştirir.
        /// </summary>
[Authorize(Roles = "HotelAdmin,Management,DepartmentManager,Employee")]
        [HttpGet("work-items/{id:int}/messages")]
        public async Task<ResponseDto<IList<MobileStaffChatMessageResponse>>> GetWorkItemMessages(int id, CancellationToken cancellationToken)
        {
            var serviceRequest = await QueryMobileWorkItems()
                .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

            if (serviceRequest is null)
            {
                return new ResponseDto<IList<MobileStaffChatMessageResponse>>().Fail("Is bulunamadi.", 404);
            }

            if (!await CanAccessWorkItemAsync(serviceRequest, cancellationToken))
            {
                return new ResponseDto<IList<MobileStaffChatMessageResponse>>().Fail("Bu isin mesajlarina erisim yetkiniz yok.", 403);
            }

            var queryResponse = await _mediator.Send(new GetServiceRequestMessagesQueryRequest
            {
                ServiceRequestId = id
            }, cancellationToken);

            if (!queryResponse.IsSuccess || queryResponse.Data is null)
            {
                return new ResponseDto<IList<MobileStaffChatMessageResponse>>()
                    .Fail(queryResponse.Errors ?? new List<string> { "Mesajlar yuklenemedi." }, queryResponse.StatusCode);
            }

            var guestName = BuildGuestName(serviceRequest);
            var employeeName = serviceRequest.AssignedEmployee is null
                ? "Personel"
                : $"{serviceRequest.AssignedEmployee.Name} {serviceRequest.AssignedEmployee.Surname}".Trim();

            var messages = queryResponse.Data.Select(x => new MobileStaffChatMessageResponse
            {
                Id = x.Id,
                ServiceRequestId = id,
                SenderType = x.SenderType.ToString(),
                OriginalText = x.OriginalText,
                TranslatedText = x.TranslatedText,
                SenderName = x.SenderType == MessageSenderTypeEnum.Customer ? guestName : employeeName,
                SentAt = x.SentAt
            }).ToList();

            return new ResponseDto<IList<MobileStaffChatMessageResponse>>().Success(messages);
        }

        /// <summary>
        /// SendWorkItemMessage işlemini gerçekleştirir.
        /// </summary>
[Authorize(Roles = "HotelAdmin,Management,DepartmentManager,Employee")]
        [HttpPost("work-items/{id:int}/message")]
        public async Task<ResponseDto<MobileStaffChatMessageResponse>> SendWorkItemMessage(
            int id,
            [FromBody] MobileStaffSendMessageRequest request,
            CancellationToken cancellationToken)
        {
            var serviceRequest = await QueryMobileWorkItems()
                .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

            if (serviceRequest is null)
            {
                return new ResponseDto<MobileStaffChatMessageResponse>().Fail("Is bulunamadi.", 404);
            }

            if (!await CanAccessWorkItemAsync(serviceRequest, cancellationToken))
            {
                return new ResponseDto<MobileStaffChatMessageResponse>().Fail("Bu ise mesaj yazma yetkiniz yok.", 403);
            }

            if (string.IsNullOrWhiteSpace(request.Message))
            {
                return new ResponseDto<MobileStaffChatMessageResponse>().Fail("Mesaj zorunludur.", 400);
            }

            var user = await ResolveCurrentStaffUserAsync(cancellationToken);
            var languageCode = string.IsNullOrWhiteSpace(user?.PreferredLanguageCode) ? "tr-TR" : user.PreferredLanguageCode;
            var commandResponse = await _mediator.Send(new CreateServiceRequestMessageCommandRequest
            {
                ServiceRequestId = id,
                SenderUserId = ResolveUserId(),
                SenderType = MessageSenderTypeEnum.Employee,
                OriginalLanguageCode = languageCode,
                OriginalText = request.Message.Trim(),
                MessageType = "Text"
            }, cancellationToken);

            if (!commandResponse.IsSuccess || commandResponse.Data is null)
            {
                return new ResponseDto<MobileStaffChatMessageResponse>()
                    .Fail(commandResponse.Errors ?? new List<string> { "Mesaj gonderilemedi." }, commandResponse.StatusCode);
            }

            var senderName = user?.Employee is null
                ? user?.UserName ?? "Personel"
                : $"{user.Employee.Name} {user.Employee.Surname}".Trim();

            var response = new MobileStaffChatMessageResponse
            {
                Id = commandResponse.Data.Id,
                ServiceRequestId = commandResponse.Data.ServiceRequestId,
                SenderType = commandResponse.Data.SenderType,
                OriginalText = commandResponse.Data.OriginalText,
                TranslatedText = commandResponse.Data.TranslatedText,
                SenderName = string.IsNullOrWhiteSpace(senderName) ? "Personel" : senderName,
                SentAt = commandResponse.Data.SentAt
            };

            await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.ServiceRequest(id))
                .SendAsync("ServiceRequestMessageCreated", response, cancellationToken);
            await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.GuestStay(serviceRequest.GuestStayId))
                .SendAsync("ServiceRequestMessageCreated", response, cancellationToken);
            await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Reception(serviceRequest.HotelId))
                .SendAsync("ServiceRequestUpdated", new { Id = serviceRequest.Id, Status = (int)serviceRequest.Status }, cancellationToken);

            return new ResponseDto<MobileStaffChatMessageResponse>().Success(response);
        }

        private IQueryable<Users> QueryStaffUser()
        {
            return _dbContext.Set<Users>()
                .Include(x => x.Role)
                .Include(x => x.Employee)
                    .ThenInclude(x => x!.Hotel)
                .Include(x => x.Employee)
                    .ThenInclude(x => x!.EmployeeType)
                    .ThenInclude(x => x!.Department)
                .Where(x => !x.IsDeleted);
        }

        private IQueryable<ServiceRequest> QueryMobileWorkItems(bool enableTracking = false)
        {
            var query = _dbContext.ServiceRequests
                .Include(x => x.Room)
                .Include(x => x.Customer)
                .Include(x => x.GuestStay)
                    .ThenInclude(x => x.Customers)
                .Include(x => x.Department)
                .Include(x => x.ServiceDefinition)
                    .ThenInclude(x => x!.ServiceCategory)
                .Include(x => x.AssignedEmployee)
                .Include(x => x.Conversation)
                    .ThenInclude(x => x!.Messages)
                .Where(x => !x.IsDeleted &&
                            x.Status != ServiceRequestStatusEnum.Completed &&
                            x.Status != ServiceRequestStatusEnum.Closed &&
                            x.Status != ServiceRequestStatusEnum.Cancelled);

            return enableTracking ? query : query.AsNoTracking();
        }

        private async Task<Users?> ResolveCurrentStaffUserAsync(CancellationToken cancellationToken)
        {
            var userId = ResolveUserId();
            if (!userId.HasValue)
            {
                return null;
            }

            return await QueryStaffUser()
                .FirstOrDefaultAsync(x => x.Id == userId.Value, cancellationToken);
        }

        private async Task<bool> CanAccessWorkItemAsync(ServiceRequest serviceRequest, CancellationToken cancellationToken)
        {
            var user = await ResolveCurrentStaffUserAsync(cancellationToken);
            var employee = user?.Employee;
            if (user is null || employee is null)
            {
                return false;
            }

            var roleName = user.Role?.Name ?? string.Empty;
            if (RoleEquals(roleName, "HotelAdmin") || RoleEquals(roleName, "Management"))
            {
                return employee.HotelId == serviceRequest.HotelId;
            }

            if (RoleEquals(roleName, "DepartmentManager"))
            {
                return serviceRequest.AssignedEmployeeId == employee.Id ||
                       (employee.EmployeeType?.DepartmentId is not null &&
                        serviceRequest.DepartmentId == employee.EmployeeType.DepartmentId);
            }

            return serviceRequest.AssignedEmployeeId == employee.Id ||
                   (!serviceRequest.AssignedEmployeeId.HasValue &&
                    employee.EmployeeType?.DepartmentId is not null &&
                    serviceRequest.DepartmentId == employee.EmployeeType.DepartmentId);
        }

        private async Task BroadcastWorkItemAsync(ServiceRequest serviceRequest, string eventName, CancellationToken cancellationToken)
        {
            var payload = MapWorkItem(serviceRequest);

            await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Hotel(serviceRequest.HotelId))
                .SendAsync(eventName, payload, cancellationToken);
            await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Reception(serviceRequest.HotelId))
                .SendAsync(eventName, payload, cancellationToken);
            await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.GuestStay(serviceRequest.GuestStayId))
                .SendAsync(eventName, payload, cancellationToken);

            if (serviceRequest.DepartmentId.HasValue)
            {
                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Department(serviceRequest.DepartmentId.Value))
                    .SendAsync(eventName, payload, cancellationToken);
            }

            if (serviceRequest.AssignedEmployeeId.HasValue)
            {
                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Employee(serviceRequest.AssignedEmployeeId.Value))
                    .SendAsync(eventName, payload, cancellationToken);
            }
        }

        private static MobileStaffWorkItemResponse MapWorkItem(ServiceRequest request)
        {
            var guestName = BuildGuestName(request);

            var serviceName = request.ServiceDefinition?.Name
                              ?? request.ServiceDefinition?.ServiceCategory?.Name
                              ?? request.ServiceType.ToString();

            var unreadMessages = request.Conversation?.Messages.Count(x => !x.IsDeleted && x.SenderType != MessageSenderTypeEnum.Employee) ?? 0;

            return new MobileStaffWorkItemResponse
            {
                Id = request.Id,
                Icon = BuildIcon(serviceName, request.ServiceType),
                Title = string.IsNullOrWhiteSpace(request.Title) ? serviceName : request.Title,
                Room = request.Room?.Name ?? (request.RoomId.HasValue ? $"Oda {request.RoomId.Value}" : "Oda -"),
                RoomId = request.RoomId,
                GuestName = string.IsNullOrWhiteSpace(guestName) ? "Misafir" : guestName,
                GuestLanguage = ResolveLanguageName(request.LanguageCode),
                ServiceType = serviceName,
                Priority = ResolvePriorityDisplayName(request.Priority),
                EstimatedTime = BuildEstimatedTime(request),
                Status = ResolveStatusDisplayName(request.Status),
                StatusKey = ResolveStatusKey(request.Status),
                CreatedAt = request.RequestedAt.ToLocalTime().ToString("dd.MM.yyyy HH:mm"),
                AssignedBy = request.AssignedEmployee is null ? "Resepsiyon" : "Sistem",
                Description = request.Description ?? string.Empty,
                Note = request.ResolutionNote ?? string.Empty,
                UnreadMessages = unreadMessages,
                RequiresPhotoProof = serviceName.Contains("Teknik", StringComparison.OrdinalIgnoreCase),
                RequiresRoomQr = serviceName.Contains("Teknik", StringComparison.OrdinalIgnoreCase)
            };
        }

        private static string BuildGuestName(ServiceRequest request)
        {
            var stayCustomer = request.GuestStay?.Customers
                .OrderByDescending(x => x.IsPrimaryGuest)
                .FirstOrDefault();

            return request.Customer is not null
                ? $"{request.Customer.Name} {request.Customer.SurName}".Trim()
                : stayCustomer is not null
                    ? $"{stayCustomer.Name} {stayCustomer.SurName}".Trim()
                    : "Misafir";
        }

        private static bool TryResolveStatus(string? statusKey, out ServiceRequestStatusEnum status)
        {
            status = statusKey?.Trim().ToLowerInvariant() switch
            {
                "assigned" or "new" => ServiceRequestStatusEnum.Assigned,
                "on-the-way" => ServiceRequestStatusEnum.OnTheWay,
                "arrived" => ServiceRequestStatusEnum.WaitingCustomer,
                "in-progress" => ServiceRequestStatusEnum.InProgress,
                "completed" => ServiceRequestStatusEnum.Completed,
                "incomplete" => ServiceRequestStatusEnum.Cancelled,
                _ => 0
            };

            return status != 0;
        }

        private static string ResolveStatusKey(ServiceRequestStatusEnum status)
        {
            return status switch
            {
                ServiceRequestStatusEnum.Assigned => "assigned",
                ServiceRequestStatusEnum.OnTheWay => "on-the-way",
                ServiceRequestStatusEnum.WaitingCustomer => "arrived",
                ServiceRequestStatusEnum.InProgress => "in-progress",
                ServiceRequestStatusEnum.Completed => "completed",
                ServiceRequestStatusEnum.Cancelled => "incomplete",
                ServiceRequestStatusEnum.Open => "new",
                _ => status.ToString().ToLowerInvariant()
            };
        }

        private static string ResolveStatusDisplayName(ServiceRequestStatusEnum status)
        {
            return status switch
            {
                ServiceRequestStatusEnum.Open => "Yeni",
                ServiceRequestStatusEnum.Assigned => "Yeni Atandı",
                ServiceRequestStatusEnum.OnTheWay => "Yola Çıktı",
                ServiceRequestStatusEnum.WaitingCustomer => "Odaya Ulaştı",
                ServiceRequestStatusEnum.InProgress => "İşlemde",
                ServiceRequestStatusEnum.Completed => "Tamamlandı",
                ServiceRequestStatusEnum.Cancelled => "Tamamlanamadı",
                ServiceRequestStatusEnum.Closed => "Kapandı",
                _ => status.ToString()
            };
        }

        private static string ResolvePriorityDisplayName(ServiceRequestPriorityEnum priority)
        {
            return priority switch
            {
                ServiceRequestPriorityEnum.Low => "Düşük",
                ServiceRequestPriorityEnum.High => "Yüksek",
                ServiceRequestPriorityEnum.Critical => "Acil",
                _ => "Normal"
            };
        }

        private static string ResolveLanguageName(string? languageCode)
        {
            return (languageCode ?? "tr-TR").Split('-')[0].ToLowerInvariant() switch
            {
                "en" => "İngilizce",
                "de" => "Almanca",
                "fr" => "Fransızca",
                "ar" => "Arapça",
                "ru" => "Rusça",
                "es" => "İspanyolca",
                _ => "Türkçe"
            };
        }

        private static string BuildEstimatedTime(ServiceRequest request)
        {
            if (request.DueAt.HasValue)
            {
                var minutes = Math.Max(1, (int)Math.Ceiling((request.DueAt.Value - DateTime.UtcNow).TotalMinutes));
                return $"{minutes} dk";
            }

            return request.Priority == ServiceRequestPriorityEnum.Critical ? "5 dk" :
                   request.Priority == ServiceRequestPriorityEnum.High ? "10 dk" :
                   "20 dk";
        }

        private static string BuildIcon(string serviceName, ServicesEnum serviceType)
        {
            if (serviceName.Contains("Havlu", StringComparison.OrdinalIgnoreCase)) return "HV";
            if (serviceName.Contains("Teknik", StringComparison.OrdinalIgnoreCase)) return "TS";
            if (serviceName.Contains("Minibar", StringComparison.OrdinalIgnoreCase)) return "MB";
            if (serviceName.Contains("Temizlik", StringComparison.OrdinalIgnoreCase)) return "TM";
            if (serviceName.Contains("Yemek", StringComparison.OrdinalIgnoreCase) || serviceName.Contains("Menü", StringComparison.OrdinalIgnoreCase)) return "YM";

            return serviceType.ToString().Length >= 2
                ? serviceType.ToString()[..2].ToUpperInvariant()
                : "SR";
        }

        private int? ResolveUserId()
        {
            var idClaim = User.FindFirst("Id")?.Value
                ?? User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            return int.TryParse(idClaim, out var id) ? id : null;
        }

        private static bool IsMobileStaffRole(string roleName)
        {
            return !string.IsNullOrWhiteSpace(roleName) && !BlockedMobileRoles.Contains(roleName);
        }

        private static MobileStaffProfileDto BuildStaffProfile(Users user)
        {
            var employee = user.Employee;
            var roleName = user.Role?.Name ?? string.Empty;

            return new MobileStaffProfileDto
            {
                UserId = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                RoleId = user.RoleId,
                RoleName = roleName,
                EmployeeId = employee?.Id,
                EmployeeCode = employee?.EmployeeCode,
                FullName = employee is null
                    ? user.UserName ?? user.Email
                    : $"{employee.Name} {employee.Surname}".Trim(),
                FirstName = employee?.Name,
                LastName = employee?.Surname,
                ImageUrl = employee?.ImageUrl,
                HotelId = employee?.HotelId,
                HotelName = employee?.Hotel?.Name,
                DepartmentId = employee?.EmployeeType?.DepartmentId,
                DepartmentName = employee?.EmployeeType?.Department?.Name,
                EmployeeTypeId = employee?.EmployeeTypeId,
                EmployeeTypeName = employee?.EmployeeType?.Name,
                IsAvailableForTask = employee?.IsAvailableForTask ?? false,
                IsManager = string.Equals(roleName, "HotelAdmin", StringComparison.OrdinalIgnoreCase) ||
                            string.Equals(roleName, "Management", StringComparison.OrdinalIgnoreCase) ||
                            string.Equals(roleName, "DepartmentManager", StringComparison.OrdinalIgnoreCase),
                PreferredLanguageCode = user.PreferredLanguageCode,
                LastLoginAt = user.LastLoginAt
            };
        }

        private static IList<MobileStaffNavigationItemDto> BuildNavigation(string roleName, Employee? employee)
        {
            var items = new List<MobileStaffNavigationItemDto>();

            void Add(string key, string title, string route, string icon, int order)
            {
                items.Add(new MobileStaffNavigationItemDto
                {
                    Key = key,
                    Title = title,
                    Route = route,
                    Icon = icon,
                    Order = order
                });
            }

            bool isReceptionist = employee?.EmployeeType?.Name == "Resepsiyonist" || 
                                  employee?.EmployeeType?.DepartmentId == 1;

            if (RoleEquals(roleName, "HotelAdmin"))
            {
                Add("hotel-dashboard", "Otel Ozeti", "/staff/hotel-dashboard", "layout-dashboard", 10);
                Add("operations", "Operasyon", "/staff/operations", "activity", 20);
                Add("rooms", "Odalar", "/staff/rooms", "bed", 30);
                Add("service-requests", "Talepler", "/staff/service-requests", "bell", 40);
                Add("messages", "Mesajlar", "/staff/messages", "message-circle", 50);
                Add("announcements", "Duyurular", "/staff/announcements", "megaphone", 60);
                Add("staff", "Personel", "/staff/employees", "users", 70);
                Add("reports", "Raporlar", "/staff/reports", "bar-chart", 80);
            }
            else if (isReceptionist)
            {
                Add("reception-dashboard", "Resepsiyon", "/staff/reception-dashboard", "layout-dashboard", 10);
                Add("service-requests", "Talepler", "/staff/service-requests", "bell", 20);
                Add("messages", "Mesajlar", "/staff/messages", "message-circle", 30);
                Add("attendance", "Vardiya", "/staff/attendance", "clock", 40);
            }
            else if (RoleEquals(roleName, "Management"))
            {
                Add("management-dashboard", "Yonetim Ozeti", "/staff/management-dashboard", "layout-dashboard", 10);
                Add("service-requests", "Talepler", "/staff/service-requests", "bell", 20);
                Add("rooms", "Odalar", "/staff/rooms", "bed", 30);
                Add("staff-performance", "Performans", "/staff/performance", "trending-up", 40);
                Add("reports", "Raporlar", "/staff/reports", "bar-chart", 50);
                Add("announcements", "Duyurular", "/staff/announcements", "megaphone", 60);
            }
            else if (RoleEquals(roleName, "DepartmentManager"))
            {
                Add("department-dashboard", "Departman", "/staff/department-dashboard", "layout-dashboard", 10);
                Add("team-requests", "Ekip Talepleri", "/staff/team-requests", "bell", 20);
                Add("my-tasks", "Gorevlerim", "/staff/tasks", "check-square", 30);
                Add("team", "Ekibim", "/staff/team", "users", 40);
                Add("stock", "Stok Talepleri", "/staff/stock", "package", 50);
                Add("messages", "Mesajlar", "/staff/messages", "message-circle", 60);
            }
            else
            {
                Add("my-dashboard", "Gunum", "/staff/my-dashboard", "layout-dashboard", 10);
                Add("assigned-requests", "Atanan Talepler", "/staff/assigned-requests", "bell", 20);
                Add("my-tasks", "Gorevlerim", "/staff/tasks", "check-square", 30);
                Add("messages", "Mesajlar", "/staff/messages", "message-circle", 40);
                Add("attendance", "Vardiya", "/staff/attendance", "clock", 50);
                Add("documents", "Belgeler", "/staff/documents", "file-text", 60);
            }

            Add("internal-announcements", "Personel Duyurulari", "/staff/internal-announcements", "megaphone", 900);
            return items.OrderBy(x => x.Order).ToList();
        }

        private static IList<string> BuildApiScopes(string roleName, Employee? employee)
        {
            var scopes = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "mobile.staff.me",
                "hr.internal-announcements.read"
            };

            if (RoleEquals(roleName, "HotelAdmin"))
            {
                scopes.UnionWith(new[]
                {
                    "hotel.dashboard.read",
                    "rooms.read",
                    "service-requests.hotel.read",
                    "service-requests.update",
                    "employees.read",
                    "reports.read",
                    "announcements.manage",
                    "conversations.read"
                });
            }
            else if (RoleEquals(roleName, "Management"))
            {
                scopes.UnionWith(new[]
                {
                    "hotel.dashboard.read",
                    "rooms.read",
                    "service-requests.hotel.read",
                    "service-requests.update",
                    "employees.read",
                    "reports.read",
                    "conversations.read"
                });
            }
            else if (RoleEquals(roleName, "DepartmentManager"))
            {
                scopes.UnionWith(new[]
                {
                    "department.dashboard.read",
                    "service-requests.department.read",
                    "service-requests.update",
                    "employees.department.read",
                    "stock-requests.manage",
                    "leave-requests.approve",
                    "conversations.read"
                });
            }
            else
            {
                scopes.UnionWith(new[]
                {
                    "service-requests.assigned.read",
                    "service-requests.update",
                    "employee-tasks.read",
                    "employee-tasks.update",
                    "attendance.read",
                    "documents.read",
                    "conversations.read"
                });
            }

            if (employee?.HotelId is not null)
            {
                scopes.Add("hotel.bound");
            }

            if (employee?.EmployeeType?.DepartmentId is not null)
            {
                scopes.Add("department.bound");
            }

            return scopes.OrderBy(x => x).ToList();
        }

        private static string ResolveStartupRoute(string roleName, Employee? employee)
        {
            if (RoleEquals(roleName, "HotelAdmin")) return "/staff/hotel-dashboard";
            if (RoleEquals(roleName, "Management")) return "/staff/management-dashboard";
            if (RoleEquals(roleName, "DepartmentManager")) return "/staff/department-dashboard";

            return "/staff/my-dashboard";
        }

        private static MobileStaffRealtimeDto BuildRealtime(Users user)
        {
            var employee = user.Employee;
            var groups = new List<string>();

            if (employee?.HotelId is not null)
            {
                groups.Add($"hotel-{employee.HotelId.Value}");
                groups.Add($"reception-{employee.HotelId.Value}");
            }

            if (employee?.EmployeeType is not null)
            {
                groups.Add($"department-{employee.EmployeeType.DepartmentId}");
            }

            if (employee is not null)
            {
                groups.Add($"employee-{employee.Id}");
            }

            return new MobileStaffRealtimeDto
            {
                HubUrl = "/hubs/hotel-operations",
                Groups = groups.Distinct().ToList()
            };
        }

        private static bool RoleEquals(string roleName, string expected)
        {
            return string.Equals(roleName, expected, StringComparison.OrdinalIgnoreCase);
        }
    }

/// <summary>
/// MobileStaffLoginRequest sınıfını temsil eder.
/// </summary>
public class MobileStaffLoginRequest
    {
/// <summary>
/// Email değerini alır veya ayarlar.
/// </summary>
public string Email { get; set; } = string.Empty;
/// <summary>
/// Password değerini alır veya ayarlar.
/// </summary>
public string Password { get; set; } = string.Empty;
/// <summary>
/// DeviceId değerini alır veya ayarlar.
/// </summary>
public string? DeviceId { get; set; }
/// <summary>
/// DevicePlatform değerini alır veya ayarlar.
/// </summary>
public string? DevicePlatform { get; set; }
    }

/// <summary>
/// MobileStaffLoginResponse sınıfını temsil eder.
/// </summary>
public class MobileStaffLoginResponse : MobileStaffMeResponse
    {
/// <summary>
/// Token değerini alır veya ayarlar.
/// </summary>
public string Token { get; set; } = string.Empty;
/// <summary>
/// TokenExpireDate değerini alır veya ayarlar.
/// </summary>
public DateTime TokenExpireDate { get; set; }
    }

/// <summary>
/// MobileStaffMeResponse sınıfını temsil eder.
/// </summary>
public class MobileStaffMeResponse
    {
/// <summary>
/// Staff değerini alır veya ayarlar.
/// </summary>
public MobileStaffProfileDto Staff { get; set; } = new();
/// <summary>
/// Navigation değerini alır veya ayarlar.
/// </summary>
public IList<MobileStaffNavigationItemDto> Navigation { get; set; } = new List<MobileStaffNavigationItemDto>();
/// <summary>
/// ApiScopes değerini alır veya ayarlar.
/// </summary>
public IList<string> ApiScopes { get; set; } = new List<string>();
/// <summary>
/// StartupRoute değerini alır veya ayarlar.
/// </summary>
public string StartupRoute { get; set; } = "/staff/my-dashboard";
/// <summary>
/// Realtime değerini alır veya ayarlar.
/// </summary>
public MobileStaffRealtimeDto Realtime { get; set; } = new();
    }

/// <summary>
/// MobileStaffDeviceTokenRequest sınıfını temsil eder.
/// </summary>
public class MobileStaffDeviceTokenRequest
    {
/// <summary>
/// Token değerini alır veya ayarlar.
/// </summary>
public string Token { get; set; } = string.Empty;
/// <summary>
/// Platform değerini alır veya ayarlar.
/// </summary>
public string? Platform { get; set; }
/// <summary>
/// DeviceId değerini alır veya ayarlar.
/// </summary>
public string? DeviceId { get; set; }
    }

/// <summary>
/// MobileStaffProfileDto sınıfını temsil eder.
/// </summary>
public class MobileStaffProfileDto
    {
/// <summary>
/// UserId değerini alır veya ayarlar.
/// </summary>
public int UserId { get; set; }
/// <summary>
/// Email değerini alır veya ayarlar.
/// </summary>
public string Email { get; set; } = string.Empty;
/// <summary>
/// UserName değerini alır veya ayarlar.
/// </summary>
public string? UserName { get; set; }
/// <summary>
/// RoleId değerini alır veya ayarlar.
/// </summary>
public int RoleId { get; set; }
/// <summary>
/// RoleName değerini alır veya ayarlar.
/// </summary>
public string RoleName { get; set; } = string.Empty;
/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int? EmployeeId { get; set; }
/// <summary>
/// EmployeeCode değerini alır veya ayarlar.
/// </summary>
public string? EmployeeCode { get; set; }
/// <summary>
/// FullName değerini alır veya ayarlar.
/// </summary>
public string FullName { get; set; } = string.Empty;
/// <summary>
/// FirstName değerini alır veya ayarlar.
/// </summary>
public string? FirstName { get; set; }
/// <summary>
/// LastName değerini alır veya ayarlar.
/// </summary>
public string? LastName { get; set; }
/// <summary>
/// ImageUrl değerini alır veya ayarlar.
/// </summary>
public string? ImageUrl { get; set; }
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int? HotelId { get; set; }
/// <summary>
/// HotelName değerini alır veya ayarlar.
/// </summary>
public string? HotelName { get; set; }
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int? DepartmentId { get; set; }
/// <summary>
/// DepartmentName değerini alır veya ayarlar.
/// </summary>
public string? DepartmentName { get; set; }
/// <summary>
/// EmployeeTypeId değerini alır veya ayarlar.
/// </summary>
public int? EmployeeTypeId { get; set; }
/// <summary>
/// EmployeeTypeName değerini alır veya ayarlar.
/// </summary>
public string? EmployeeTypeName { get; set; }
/// <summary>
/// IsAvailableForTask değerini alır veya ayarlar.
/// </summary>
public bool IsAvailableForTask { get; set; }
/// <summary>
/// IsManager değerini alır veya ayarlar.
/// </summary>
public bool IsManager { get; set; }
/// <summary>
/// PreferredLanguageCode değerini alır veya ayarlar.
/// </summary>
public string PreferredLanguageCode { get; set; } = "tr-TR";
/// <summary>
/// LastLoginAt değerini alır veya ayarlar.
/// </summary>
public DateTime? LastLoginAt { get; set; }
    }

/// <summary>
/// MobileStaffNavigationItemDto sınıfını temsil eder.
/// </summary>
public class MobileStaffNavigationItemDto
    {
/// <summary>
/// Key değerini alır veya ayarlar.
/// </summary>
public string Key { get; set; } = string.Empty;
/// <summary>
/// Title değerini alır veya ayarlar.
/// </summary>
public string Title { get; set; } = string.Empty;
/// <summary>
/// Route değerini alır veya ayarlar.
/// </summary>
public string Route { get; set; } = string.Empty;
/// <summary>
/// Icon değerini alır veya ayarlar.
/// </summary>
public string Icon { get; set; } = string.Empty;
/// <summary>
/// Order değerini alır veya ayarlar.
/// </summary>
public int Order { get; set; }
    }

/// <summary>
/// MobileStaffRealtimeDto sınıfını temsil eder.
/// </summary>
public class MobileStaffRealtimeDto
    {
/// <summary>
/// HubUrl değerini alır veya ayarlar.
/// </summary>
public string HubUrl { get; set; } = "/hubs/hotel-operations";
/// <summary>
/// Groups değerini alır veya ayarlar.
/// </summary>
public IList<string> Groups { get; set; } = new List<string>();
    }

/// <summary>
/// MobileStaffWorkItemResponse sınıfını temsil eder.
/// </summary>
public class MobileStaffWorkItemResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Icon değerini alır veya ayarlar.
/// </summary>
public string Icon { get; set; } = "SR";
/// <summary>
/// Title değerini alır veya ayarlar.
/// </summary>
public string Title { get; set; } = string.Empty;
/// <summary>
/// Room değerini alır veya ayarlar.
/// </summary>
public string Room { get; set; } = string.Empty;
/// <summary>
/// RoomId değerini alır veya ayarlar.
/// </summary>
public int? RoomId { get; set; }
/// <summary>
/// GuestName değerini alır veya ayarlar.
/// </summary>
public string GuestName { get; set; } = string.Empty;
/// <summary>
/// GuestLanguage değerini alır veya ayarlar.
/// </summary>
public string GuestLanguage { get; set; } = "Türkçe";
/// <summary>
/// ServiceType değerini alır veya ayarlar.
/// </summary>
public string ServiceType { get; set; } = string.Empty;
/// <summary>
/// Priority değerini alır veya ayarlar.
/// </summary>
public string Priority { get; set; } = "Normal";
/// <summary>
/// EstimatedTime değerini alır veya ayarlar.
/// </summary>
public string EstimatedTime { get; set; } = "10 dk";
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public string Status { get; set; } = string.Empty;
/// <summary>
/// StatusKey değerini alır veya ayarlar.
/// </summary>
public string StatusKey { get; set; } = string.Empty;
/// <summary>
/// CreatedAt değerini alır veya ayarlar.
/// </summary>
public string CreatedAt { get; set; } = string.Empty;
/// <summary>
/// AssignedBy değerini alır veya ayarlar.
/// </summary>
public string AssignedBy { get; set; } = "Sistem";
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string Description { get; set; } = string.Empty;
/// <summary>
/// Note değerini alır veya ayarlar.
/// </summary>
public string Note { get; set; } = string.Empty;
/// <summary>
/// UnreadMessages değerini alır veya ayarlar.
/// </summary>
public int UnreadMessages { get; set; }
/// <summary>
/// RequiresPhotoProof değerini alır veya ayarlar.
/// </summary>
public bool RequiresPhotoProof { get; set; }
/// <summary>
/// RequiresRoomQr değerini alır veya ayarlar.
/// </summary>
public bool RequiresRoomQr { get; set; }
    }

/// <summary>
/// MobileStaffUpdateWorkStatusRequest sınıfını temsil eder.
/// </summary>
public class MobileStaffUpdateWorkStatusRequest
    {
/// <summary>
/// StatusKey değerini alır veya ayarlar.
/// </summary>
public string StatusKey { get; set; } = string.Empty;
/// <summary>
/// Note değerini alır veya ayarlar.
/// </summary>
public string? Note { get; set; }
/// <summary>
/// IncompleteReason değerini alır veya ayarlar.
/// </summary>
public string? IncompleteReason { get; set; }
    }

/// <summary>
/// MobileStaffWorkStatusResponse sınıfını temsil eder.
/// </summary>
public class MobileStaffWorkStatusResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public string Status { get; set; } = string.Empty;
/// <summary>
/// StatusKey değerini alır veya ayarlar.
/// </summary>
public string StatusKey { get; set; } = string.Empty;
/// <summary>
/// StartedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? StartedAt { get; set; }
/// <summary>
/// CompletedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? CompletedAt { get; set; }
    }

/// <summary>
/// MobileStaffUpdateAvailabilityRequest sınıfını temsil eder.
/// </summary>
public class MobileStaffUpdateAvailabilityRequest
    {
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public string Status { get; set; } = "Müsait";
    }

/// <summary>
/// MobileStaffAvailabilityResponse sınıfını temsil eder.
/// </summary>
public class MobileStaffAvailabilityResponse
    {
/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int? EmployeeId { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public string Status { get; set; } = "Müsait";
/// <summary>
/// IsAvailableForTask değerini alır veya ayarlar.
/// </summary>
public bool IsAvailableForTask { get; set; }
    }

/// <summary>
/// MobileStaffVerifyRoomQrRequest sınıfını temsil eder.
/// </summary>
public class MobileStaffVerifyRoomQrRequest
    {
/// <summary>
/// RoomQrCode değerini alır veya ayarlar.
/// </summary>
public string RoomQrCode { get; set; } = string.Empty;
    }

/// <summary>
/// MobileStaffQrVerifyResponse sınıfını temsil eder.
/// </summary>
public class MobileStaffQrVerifyResponse
    {
/// <summary>
/// WorkItemId değerini alır veya ayarlar.
/// </summary>
public int WorkItemId { get; set; }
/// <summary>
/// IsVerified değerini alır veya ayarlar.
/// </summary>
public bool IsVerified { get; set; }
/// <summary>
/// Message değerini alır veya ayarlar.
/// </summary>
public string Message { get; set; } = string.Empty;
    }

/// <summary>
/// MobileStaffPhotoProofRequest sınıfını temsil eder.
/// </summary>
public class MobileStaffPhotoProofRequest
    {
/// <summary>
/// PhotoType değerini alır veya ayarlar.
/// </summary>
public string PhotoType { get; set; } = "After";
/// <summary>
/// ImageBase64 değerini alır veya ayarlar.
/// </summary>
public string? ImageBase64 { get; set; }
/// <summary>
/// Note değerini alır veya ayarlar.
/// </summary>
public string? Note { get; set; }
    }

/// <summary>
/// MobileStaffPhotoProofResponse sınıfını temsil eder.
/// </summary>
public class MobileStaffPhotoProofResponse
    {
/// <summary>
/// WorkItemId değerini alır veya ayarlar.
/// </summary>
public int WorkItemId { get; set; }
/// <summary>
/// PhotoType değerini alır veya ayarlar.
/// </summary>
public string PhotoType { get; set; } = string.Empty;
/// <summary>
/// UploadedAt değerini alır veya ayarlar.
/// </summary>
public DateTime UploadedAt { get; set; }
    }

/// <summary>
/// MobileStaffSendMessageRequest sınıfını temsil eder.
/// </summary>
public class MobileStaffSendMessageRequest
    {
/// <summary>
/// Message değerini alır veya ayarlar.
/// </summary>
public string Message { get; set; } = string.Empty;
    }

/// <summary>
/// MobileStaffChatMessageResponse sınıfını temsil eder.
/// </summary>
public class MobileStaffChatMessageResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// ServiceRequestId değerini alır veya ayarlar.
/// </summary>
public int ServiceRequestId { get; set; }
/// <summary>
/// SenderType değerini alır veya ayarlar.
/// </summary>
public string SenderType { get; set; } = string.Empty;
/// <summary>
/// OriginalText değerini alır veya ayarlar.
/// </summary>
public string OriginalText { get; set; } = string.Empty;
/// <summary>
/// TranslatedText değerini alır veya ayarlar.
/// </summary>
public string? TranslatedText { get; set; }
/// <summary>
/// SenderName değerini alır veya ayarlar.
/// </summary>
public string SenderName { get; set; } = string.Empty;
/// <summary>
/// SentAt değerini alır veya ayarlar.
/// </summary>
public DateTime SentAt { get; set; }
    }
}
