using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;
using WorigoApp.Api.Hubs;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Auth.Dtos;
using WorigoApp.Application.Helpers;
using WorigoApp.Application.Interfaces.Auth.Jwt.Tokens;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;
using WorigoApp.Persistence.Context;

namespace WorigoApp.Api.Controllers.Mobile
{
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

        public MobileStaffController(AppDbContext dbContext, ITokenService tokenService, IHubContext<HotelOperationsHub> hubContext)
        {
            _dbContext = dbContext;
            _tokenService = tokenService;
            _hubContext = hubContext;
        }

        [AllowAnonymous]
        [HttpPost("login")]
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

            if (RoleEquals(roleName, "DepartmentManager") && employee.EmployeeType?.DepartmentId is not null)
            {
                var departmentId = employee.EmployeeType.DepartmentId;
                query = query.Where(x => x.DepartmentId == departmentId || x.AssignedEmployeeId == employee.Id);
            }
            else if (!RoleEquals(roleName, "HotelAdmin") && !RoleEquals(roleName, "Management"))
            {
                query = query.Where(x => x.AssignedEmployeeId == employee.Id);
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
                .Include(x => x.Messages)
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

            return serviceRequest.AssignedEmployeeId == employee.Id;
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
            var stayCustomer = request.GuestStay?.Customers
                .OrderByDescending(x => x.IsPrimaryGuest)
                .FirstOrDefault();

            var guestName = request.Customer is not null
                ? $"{request.Customer.Name} {request.Customer.SurName}".Trim()
                : stayCustomer is not null
                    ? $"{stayCustomer.Name} {stayCustomer.SurName}".Trim()
                    : "Misafir";

            var serviceName = request.ServiceDefinition?.Name
                              ?? request.ServiceDefinition?.ServiceCategory?.Name
                              ?? request.ServiceType.ToString();

            var unreadMessages = request.Messages.Count(x => !x.IsDeleted && x.SenderType != MessageSenderTypeEnum.Employee);

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

    public class MobileStaffLoginRequest
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string? DeviceId { get; set; }
        public string? DevicePlatform { get; set; }
    }

    public class MobileStaffLoginResponse : MobileStaffMeResponse
    {
        public string Token { get; set; } = string.Empty;
        public DateTime TokenExpireDate { get; set; }
    }

    public class MobileStaffMeResponse
    {
        public MobileStaffProfileDto Staff { get; set; } = new();
        public IList<MobileStaffNavigationItemDto> Navigation { get; set; } = new List<MobileStaffNavigationItemDto>();
        public IList<string> ApiScopes { get; set; } = new List<string>();
        public string StartupRoute { get; set; } = "/staff/my-dashboard";
        public MobileStaffRealtimeDto Realtime { get; set; } = new();
    }

    public class MobileStaffProfileDto
    {
        public int UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string? UserName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; } = string.Empty;
        public int? EmployeeId { get; set; }
        public string? EmployeeCode { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ImageUrl { get; set; }
        public int? HotelId { get; set; }
        public string? HotelName { get; set; }
        public int? DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public int? EmployeeTypeId { get; set; }
        public string? EmployeeTypeName { get; set; }
        public bool IsAvailableForTask { get; set; }
        public bool IsManager { get; set; }
        public string PreferredLanguageCode { get; set; } = "tr-TR";
        public DateTime? LastLoginAt { get; set; }
    }

    public class MobileStaffNavigationItemDto
    {
        public string Key { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Route { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public int Order { get; set; }
    }

    public class MobileStaffRealtimeDto
    {
        public string HubUrl { get; set; } = "/hubs/hotel-operations";
        public IList<string> Groups { get; set; } = new List<string>();
    }

    public class MobileStaffWorkItemResponse
    {
        public int Id { get; set; }
        public string Icon { get; set; } = "SR";
        public string Title { get; set; } = string.Empty;
        public string Room { get; set; } = string.Empty;
        public int? RoomId { get; set; }
        public string GuestName { get; set; } = string.Empty;
        public string GuestLanguage { get; set; } = "Türkçe";
        public string ServiceType { get; set; } = string.Empty;
        public string Priority { get; set; } = "Normal";
        public string EstimatedTime { get; set; } = "10 dk";
        public string Status { get; set; } = string.Empty;
        public string StatusKey { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public string AssignedBy { get; set; } = "Sistem";
        public string Description { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public int UnreadMessages { get; set; }
        public bool RequiresPhotoProof { get; set; }
        public bool RequiresRoomQr { get; set; }
    }

    public class MobileStaffUpdateWorkStatusRequest
    {
        public string StatusKey { get; set; } = string.Empty;
        public string? Note { get; set; }
        public string? IncompleteReason { get; set; }
    }

    public class MobileStaffWorkStatusResponse
    {
        public int Id { get; set; }
        public string Status { get; set; } = string.Empty;
        public string StatusKey { get; set; } = string.Empty;
        public DateTime? StartedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
    }

    public class MobileStaffUpdateAvailabilityRequest
    {
        public string Status { get; set; } = "Müsait";
    }

    public class MobileStaffAvailabilityResponse
    {
        public int? EmployeeId { get; set; }
        public string Status { get; set; } = "Müsait";
        public bool IsAvailableForTask { get; set; }
    }

    public class MobileStaffVerifyRoomQrRequest
    {
        public string RoomQrCode { get; set; } = string.Empty;
    }

    public class MobileStaffQrVerifyResponse
    {
        public int WorkItemId { get; set; }
        public bool IsVerified { get; set; }
        public string Message { get; set; } = string.Empty;
    }

    public class MobileStaffPhotoProofRequest
    {
        public string PhotoType { get; set; } = "After";
        public string? ImageBase64 { get; set; }
        public string? Note { get; set; }
    }

    public class MobileStaffPhotoProofResponse
    {
        public int WorkItemId { get; set; }
        public string PhotoType { get; set; } = string.Empty;
        public DateTime UploadedAt { get; set; }
    }
}
