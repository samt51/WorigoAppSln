using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.ServiceRequests.Dtos;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;
using System.Globalization;
using System.Text;

namespace WorigoApp.Application.Features.ServiceRequests.Commands.CreateServiceRequest
{
/// <summary>
/// CreateServiceRequestCommandHandler sınıfını temsil eder.
/// </summary>
public class CreateServiceRequestCommandHandler : BaseHandler, IRequestHandler<CreateServiceRequestCommandRequest, ResponseDto<CreateServiceRequestCommandResponse>>
    {
/// <summary>
/// CreateServiceRequestCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateServiceRequestCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<CreateServiceRequestCommandResponse>> Handle(CreateServiceRequestCommandRequest request, CancellationToken cancellationToken)
        {
            var guestStay = await unitOfWork.GetReadRepository<GuestStay>()
                .GetAsync(x => x.Id == request.GuestStayId && x.IsActive && !x.IsDeleted);

            if (request.CustomerId.HasValue)
            {
                await unitOfWork.GetReadRepository<Customer>()
                    .GetAsync(x => x.Id == request.CustomerId.Value && x.GuestStayId == request.GuestStayId && !x.IsDeleted);
            }

            if (request.ConversationId.HasValue)
            {
                await unitOfWork.GetReadRepository<Conversation>()
                    .GetAsync(x =>
                        x.Id == request.ConversationId.Value &&
                        x.HotelId == guestStay.HotelId &&
                        x.GuestStayId == request.GuestStayId &&
                        !x.IsDeleted);
            }

            ServiceDefinition? serviceDefinition = null;
            if (request.ServiceDefinitionId.HasValue)
            {
                serviceDefinition = await unitOfWork.GetReadRepository<ServiceDefinition>()
                    .GetAsync(
                        x => x.Id == request.ServiceDefinitionId.Value &&
                             x.HotelId == guestStay.HotelId &&
                             x.IsActive &&
                             !x.IsDeleted,
                        include: query => query.Include(x => x.Fields));

                request.ServiceType = serviceDefinition.ServiceType;
                request.ServiceCatalogItemId = serviceDefinition.Id;
            }

            var assignments = await unitOfWork.GetReadRepository<ServiceRoleAssignments>().GetAllAsync(
                x => x.HotelId == guestStay.HotelId && x.ServicesEnumId == request.ServiceType && x.IsActive && !x.IsDeleted,
                orderBy: x => x.OrderBy(y => y.Priority));

            assignments = await BuildAssignmentCandidatesAsync(guestStay.HotelId, request, serviceDefinition, assignments);
            var assignment = assignments.FirstOrDefault();
            var assignedEmployee = await FindAvailableEmployeeAsync(guestStay.HotelId, assignments);
            var departmentId = assignment?.DepartmentId ?? serviceDefinition?.DepartmentId;

            var now = DateTime.UtcNow;

            var entity = new ServiceRequest
            {
                HotelId = guestStay.HotelId,
                GuestStayId = guestStay.Id,
                RoomId = request.RoomId ?? guestStay.RoomId,
                CustomerId = request.CustomerId,
                ServiceType = request.ServiceType,
                ServiceCatalogItemId = request.ServiceCatalogItemId,
                ServiceDefinitionId = serviceDefinition?.Id,
                Title = !string.IsNullOrWhiteSpace(request.Title) ? request.Title : serviceDefinition?.Name ?? string.Empty,
                Description = request.Description,
                LanguageCode = request.LanguageCode,
                Priority = request.Priority,
                RequestedAt = now,
                DepartmentId = departmentId,
                DueAt = assignment?.SlaMinutes is int sla ? now.AddMinutes(sla) : null,
                AssignedEmployeeId = assignedEmployee?.Id,
                AssignedAt = assignedEmployee is not null ? now : null,
                ConversationId = request.ConversationId,
                IsChatStarted = request.ConversationId.HasValue,
                Status = assignedEmployee is not null ? ServiceRequestStatusEnum.Assigned : ServiceRequestStatusEnum.Open
            };

            if (serviceDefinition is not null)
            {
                var requiredFields = serviceDefinition.Fields
                    .Where(x => x.IsActive && !x.IsDeleted && x.IsRequired)
                    .ToList();

                var submittedFieldIds = request.FieldValues
                    .Where(x => !string.IsNullOrWhiteSpace(x.Value))
                    .Select(x => x.ServiceDefinitionFieldId)
                    .ToHashSet();

                if (requiredFields.Any(x => !submittedFieldIds.Contains(x.Id)))
                {
                    throw new Exception("Servis talebi icin zorunlu alanlar eksik.");
                }
            }

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            var createdRequest = await unitOfWork.GetWriteRepository<ServiceRequest>().AddAsync(entity);
            await unitOfWork.SaveAsync(cancellationToken);

            if (serviceDefinition is not null && request.FieldValues.Any())
            {
                var allowedFields = serviceDefinition.Fields
                    .Where(x => x.IsActive && !x.IsDeleted)
                    .ToDictionary(x => x.Id);

                foreach (var fieldValue in request.FieldValues)
                {
                    if (!allowedFields.TryGetValue(fieldValue.ServiceDefinitionFieldId, out var field))
                    {
                        throw new Exception("Servis talebi icin gecersiz alan degeri gonderildi.");
                    }

                    await unitOfWork.GetWriteRepository<ServiceRequestFieldValue>().AddAsync(new ServiceRequestFieldValue
                    {
                        ServiceRequestId = createdRequest.Id,
                        ServiceDefinitionFieldId = field.Id,
                        FieldKey = string.IsNullOrWhiteSpace(fieldValue.FieldKey) ? field.FieldKey : fieldValue.FieldKey,
                        Value = fieldValue.Value
                    });
                }

                await unitOfWork.SaveAsync(cancellationToken);
            }

            var requestItems = BuildRequestItems(request, serviceDefinition);
            foreach (var item in requestItems)
            {
                await unitOfWork.GetWriteRepository<ServiceRequestItem>().AddAsync(new ServiceRequestItem
                {
                    ServiceRequestId = createdRequest.Id,
                    ServiceDefinitionId = item.ServiceDefinitionId,
                    ItemName = item.ItemName,
                    Quantity = item.Quantity,
                    Note = item.Note
                });
            }

            if (requestItems.Any())
            {
                await unitOfWork.SaveAsync(cancellationToken);
            }

            if (assignedEmployee is not null)
            {
                assignedEmployee.LastAssignedAt = now;
                await unitOfWork.GetWriteRepository<Employee>().UpdateAsync(assignedEmployee);
                await unitOfWork.SaveAsync(cancellationToken);
            }

            await unitOfWork.GetWriteRepository<ServiceRequestHistory>().AddAsync(new ServiceRequestHistory
            {
                ServiceRequestId = createdRequest.Id,
                NewStatus = createdRequest.Status,
                ChangedAt = now,
                Note = assignedEmployee is not null
                    ? $"Servis talebi olusturuldu ve personele atandi. PersonelId: {assignedEmployee.Id}"
                    : "Servis talebi olusturuldu."
            });

            var notificationResult = await CreateServiceRequestNotificationsAsync(createdRequest, assignedEmployee, now);

            await unitOfWork.SaveAsync(cancellationToken);
            await unitOfWork.CommitAsync(cancellationToken);

            return new ResponseDto<CreateServiceRequestCommandResponse>().Success(new CreateServiceRequestCommandResponse
            {
                Id = createdRequest.Id,
                HotelId = createdRequest.HotelId,
                GuestStayId = createdRequest.GuestStayId,
                Status = createdRequest.Status,
                RequestedAt = createdRequest.RequestedAt,
                DepartmentId = createdRequest.DepartmentId,
                AssignedEmployeeId = createdRequest.AssignedEmployeeId,
                DueAt = createdRequest.DueAt,
                ManagerEmployeeId = notificationResult.ManagerEmployeeId,
                NotificationIds = notificationResult.Notifications.Select(x => x.Id).ToList(),
                ReceptionEmployeeIds = notificationResult.ReceptionEmployeeIds
            });
        }

        private async Task<IList<ServiceRoleAssignments>> BuildAssignmentCandidatesAsync(
            int hotelId,
            CreateServiceRequestCommandRequest request,
            ServiceDefinition? serviceDefinition,
            IList<ServiceRoleAssignments> assignments)
        {
            if (request.ServiceType is not ServicesEnum.TechnicalNeed and not ServicesEnum.Connection)
            {
                return assignments;
            }

            var candidates = assignments.ToList();
            var candidateEmployeeTypeIds = candidates.Select(x => x.EmployeeTypeRoleId).ToHashSet();

            var technicalDepartments = await unitOfWork.GetReadRepository<Department>().GetAllAsync(
                x => x.HotelId == hotelId &&
                     !x.IsDeleted &&
                     x.IsActive &&
                     (x.Name.Contains("Teknik") || x.Name.Contains("Technical")));

            var technicalDepartmentIds = technicalDepartments.Select(x => x.Id).ToList();
            if (!technicalDepartmentIds.Any() && serviceDefinition?.DepartmentId is int serviceDepartmentId)
            {
                technicalDepartmentIds.Add(serviceDepartmentId);
            }

            if (technicalDepartmentIds.Any())
            {
                var technicalEmployeeTypes = await unitOfWork.GetReadRepository<EmployeeType>().GetAllAsync(
                    x => technicalDepartmentIds.Contains(x.DepartmentId) &&
                         !x.IsDeleted &&
                         x.IsActive);

                foreach (var employeeType in technicalEmployeeTypes)
                {
                    if (!IsTechnicalEmployeeType(employeeType.Name) || candidateEmployeeTypeIds.Contains(employeeType.Id))
                    {
                        continue;
                    }

                    candidates.Add(new ServiceRoleAssignments
                    {
                        HotelId = hotelId,
                        DepartmentId = employeeType.DepartmentId,
                        ServiceId = (int)request.ServiceType,
                        ServicesEnumId = request.ServiceType,
                        EmployeeTypeRoleId = employeeType.Id,
                        IsPrimaryAssignment = false,
                        Priority = GetTechnicalEmployeeTypeBasePriority(employeeType.Name),
                        SlaMinutes = 30,
                        IsActive = true
                    });
                    candidateEmployeeTypeIds.Add(employeeType.Id);
                }
            }

            return await PrioritizeTechnicalAssignmentsAsync(request, serviceDefinition, candidates);
        }

        private async Task<IList<ServiceRoleAssignments>> PrioritizeTechnicalAssignmentsAsync(
            CreateServiceRequestCommandRequest request,
            ServiceDefinition? serviceDefinition,
            IList<ServiceRoleAssignments> assignments)
        {
            if (!assignments.Any())
            {
                return assignments;
            }

            var requestedSpecialty = DetectTechnicalSpecialty(request, serviceDefinition);
            if (requestedSpecialty is null)
            {
                return assignments.OrderBy(x => x.Priority).ToList();
            }

            var employeeTypeIds = assignments.Select(x => x.EmployeeTypeRoleId).Distinct().ToList();
            var employeeTypes = await unitOfWork.GetReadRepository<EmployeeType>().GetAllAsync(
                x => employeeTypeIds.Contains(x.Id) && !x.IsDeleted && x.IsActive);
            var employeeTypeNameMap = employeeTypes.ToDictionary(x => x.Id, x => x.Name);

            return assignments
                .OrderBy(x => GetSpecialtySortScore(employeeTypeNameMap.GetValueOrDefault(x.EmployeeTypeRoleId), requestedSpecialty.Value))
                .ThenBy(x => x.Priority)
                .ToList();
        }

        private static TechnicalSpecialty? DetectTechnicalSpecialty(
            CreateServiceRequestCommandRequest request,
            ServiceDefinition? serviceDefinition)
        {
            var text = NormalizeForSearch(string.Join(" ", new[]
            {
                request.Title,
                request.Description,
                serviceDefinition?.Name,
                serviceDefinition?.Description,
                string.Join(" ", request.FieldValues.Select(x => $"{x.FieldKey} {x.Value}")),
                string.Join(" ", request.Items.Select(x => $"{x.ItemName} {x.Note}"))
            }.Where(x => !string.IsNullOrWhiteSpace(x))));

            if (ContainsAny(text, "klima", "havalandirma", "sogutma", "isitma", "kalorifer", "fan", "termostat", "mekanik"))
            {
                return TechnicalSpecialty.Mechanical;
            }

            if (ContainsAny(text, "elektrik", "priz", "lamba", "isik", "aydinlatma", "sigorta", "enerji", "tv", "televizyon"))
            {
                return TechnicalSpecialty.Electrical;
            }

            if (ContainsAny(text, "tesisat", "su", "musluk", "lavabo", "dus", "tuvalet", "klozet", "gider", "sifon", "sizinti", "akinti"))
            {
                return TechnicalSpecialty.Plumbing;
            }

            return null;
        }

        private static int GetSpecialtySortScore(string? employeeTypeName, TechnicalSpecialty requestedSpecialty)
        {
            var normalizedName = NormalizeForSearch(employeeTypeName ?? string.Empty);

            if (requestedSpecialty == TechnicalSpecialty.Mechanical &&
                ContainsAny(normalizedName, "mekanik", "teknik mudur"))
            {
                return ContainsAny(normalizedName, "mekanik") ? 0 : 2;
            }

            if (requestedSpecialty == TechnicalSpecialty.Electrical &&
                ContainsAny(normalizedName, "elektrik", "teknik mudur"))
            {
                return ContainsAny(normalizedName, "elektrik") ? 0 : 2;
            }

            if (requestedSpecialty == TechnicalSpecialty.Plumbing &&
                ContainsAny(normalizedName, "tesisat", "teknik mudur"))
            {
                return ContainsAny(normalizedName, "tesisat") ? 0 : 2;
            }

            return 10;
        }

        private static bool IsTechnicalEmployeeType(string employeeTypeName)
        {
            var normalizedName = NormalizeForSearch(employeeTypeName);
            return ContainsAny(normalizedName, "elektrik", "mekanik", "tesisat", "teknik mudur");
        }

        private static int GetTechnicalEmployeeTypeBasePriority(string employeeTypeName)
        {
            var normalizedName = NormalizeForSearch(employeeTypeName);
            if (ContainsAny(normalizedName, "elektrik")) return 1;
            if (ContainsAny(normalizedName, "mekanik")) return 2;
            if (ContainsAny(normalizedName, "tesisat")) return 3;
            if (ContainsAny(normalizedName, "teknik mudur")) return 4;
            return 9;
        }

        private static bool ContainsAny(string value, params string[] needles)
        {
            return needles.Any(value.Contains);
        }

        private static string NormalizeForSearch(string value)
        {
            var lowerValue = value.ToLower(new CultureInfo("tr-TR"));
            var normalized = lowerValue.Normalize(NormalizationForm.FormD);
            var builder = new StringBuilder(normalized.Length);

            foreach (var character in normalized)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(character) != UnicodeCategory.NonSpacingMark)
                {
                    builder.Append(character);
                }
            }

            return builder
                .ToString()
                .Replace('ı', 'i')
                .Normalize(NormalizationForm.FormC);
        }

        private enum TechnicalSpecialty
        {
            Electrical,
            Mechanical,
            Plumbing
        }

        private async Task<Employee?> FindAvailableEmployeeAsync(int hotelId, IList<ServiceRoleAssignments> assignments)
        {
            foreach (var assignment in assignments)
            {
                var employees = await unitOfWork.GetReadRepository<Employee>().GetAllAsync(
                    x => x.HotelId == hotelId &&
                         x.EmployeeTypeId == assignment.EmployeeTypeRoleId &&
                         x.IsActive &&
                         !x.IsDeleted &&
                         x.Status &&
                         x.IsAvailableForTask);

                if (!employees.Any())
                    continue;

                var employeeIds = employees.Select(e => e.Id).ToList();

                var activeStatuses = new[]
                {
                    ServiceRequestStatusEnum.Assigned,
                    ServiceRequestStatusEnum.InProgress,
                    ServiceRequestStatusEnum.WaitingCustomer,
                    ServiceRequestStatusEnum.OnTheWay
                };

                var activeRequests = await unitOfWork.GetReadRepository<ServiceRequest>().GetAllAsync(
                    x => x.HotelId == hotelId &&
                         x.AssignedEmployeeId.HasValue &&
                         employeeIds.Contains(x.AssignedEmployeeId.Value) &&
                         !x.IsDeleted &&
                         activeStatuses.Contains(x.Status));

                var workloadMap = activeRequests
                    .GroupBy(x => x.AssignedEmployeeId!.Value)
                    .ToDictionary(g => g.Key, g => g.Count());

                var selectedEmployee = employees
                    .Select(e => new
                    {
                        Employee = e,
                        Workload = workloadMap.TryGetValue(e.Id, out var count) ? count : 0
                    })
                    .OrderBy(x => x.Workload)
                    .ThenBy(x => x.Employee.LastAssignedAt ?? DateTime.MinValue)
                    .Select(x => x.Employee)
                    .FirstOrDefault();

                if (selectedEmployee is not null)
                {
                    return selectedEmployee;
                }
            }

            return null;
        }

        private async Task<ServiceRequestNotificationResult> CreateServiceRequestNotificationsAsync(
            ServiceRequest serviceRequest,
            Employee? assignedEmployee,
            DateTime now)
        {
            var notifications = new List<UserNotification>();
            var employeeRecipients = new HashSet<int>();
            var receptionEmployeeIds = new List<int>();
            int? managerEmployeeId = null;

            var title = "Yeni servis talebi";
            var message = string.IsNullOrWhiteSpace(serviceRequest.Title)
                ? "Yeni bir servis talebi olusturuldu."
                : $"{serviceRequest.Title} talebi olusturuldu.";

            if (assignedEmployee is not null)
            {
                AddEmployeeNotification(
                    notifications,
                    employeeRecipients,
                    serviceRequest,
                    assignedEmployee,
                    title,
                    $"{message} Talep size atandi.",
                    now);
            }

            if (serviceRequest.DepartmentId.HasValue)
            {
                notifications.Add(new UserNotification
                {
                    HotelId = serviceRequest.HotelId,
                    DepartmentId = serviceRequest.DepartmentId.Value,
                    ServiceRequestId = serviceRequest.Id,
                    Title = title,
                    Message = $"{message} Departman havuzuna eklendi.",
                    NotificationType = "ServiceRequestCreated",
                    CreatedDate = now,
                    ModifyDate = now
                });

                var department = await unitOfWork.GetReadRepository<Department>()
                    .GetAsync(d => d.Id == serviceRequest.DepartmentId.Value && !d.IsDeleted && d.IsActive);
                
                if (department?.ManagerEmployeeId.HasValue == true)
                {
                    managerEmployeeId = department.ManagerEmployeeId.Value;
                    if (assignedEmployee is null)
                    {
                        var manager = await unitOfWork.GetReadRepository<Employee>()
                            .GetAsync(e => e.Id == managerEmployeeId.Value && !e.IsDeleted && e.IsActive);
                        if (manager is not null)
                        {
                            AddEmployeeNotification(
                                notifications,
                                employeeRecipients,
                                serviceRequest,
                                manager,
                                "Atanamayan Servis Talebi",
                                $"{message} Departmanınızda müsait personel bulunmadığından atanamadı. Lütfen personel atayın.",
                                now);
                        }
                    }
                }
            }

            var receptionEmployees = await unitOfWork.GetReadRepository<Employee>().GetAllAsync(
                x => x.HotelId == serviceRequest.HotelId &&
                     x.IsActive &&
                     !x.IsDeleted &&
                     x.Status &&
                     x.UserId.HasValue &&
                     x.EmployeeType != null &&
                     (x.EmployeeType.Name.Contains("Resepsiyon") ||
                      x.EmployeeType.Name.Contains("Reception") ||
                      x.EmployeeType.Department.Name.Contains("Resepsiyon") ||
                      x.EmployeeType.Department.Name.Contains("Reception") ||
                      x.EmployeeType.Department.Name.Contains("Buro") ||
                      x.EmployeeType.Department.Name.Contains("Büro")),
                include: query => query
                    .Include(x => x.EmployeeType)
                    .ThenInclude(x => x.Department));

            var receptionMessage = assignedEmployee is not null
                ? $"{message} Resepsiyon takibi icin goruntulenebilir."
                : $"{message} Boşta (Open). Lütfen bir personel ataması gerçekleştirin.";

            foreach (var receptionEmployee in receptionEmployees)
            {
                receptionEmployeeIds.Add(receptionEmployee.Id);
                AddEmployeeNotification(
                    notifications,
                    employeeRecipients,
                    serviceRequest,
                    receptionEmployee,
                    title,
                    receptionMessage,
                    now);
            }

            if (notifications.Any())
            {
                await unitOfWork.GetWriteRepository<UserNotification>().AddRangeAsync(notifications);
            }

            return new ServiceRequestNotificationResult(
                notifications,
                receptionEmployeeIds.Distinct().ToList(),
                managerEmployeeId);
        }

        private static void AddEmployeeNotification(
            IList<UserNotification> notifications,
            ISet<int> employeeRecipients,
            ServiceRequest serviceRequest,
            Employee employee,
            string title,
            string message,
            DateTime now)
        {
            if (!employeeRecipients.Add(employee.Id))
            {
                return;
            }

            notifications.Add(new UserNotification
            {
                HotelId = serviceRequest.HotelId,
                UserId = employee.UserId,
                EmployeeId = employee.Id,
                DepartmentId = serviceRequest.DepartmentId,
                ServiceRequestId = serviceRequest.Id,
                Title = title,
                Message = message,
                NotificationType = "ServiceRequestAssigned",
                CreatedDate = now,
                ModifyDate = now
            });
        }

        private sealed record ServiceRequestNotificationResult(
            IList<UserNotification> Notifications,
            IList<int> ReceptionEmployeeIds,
            int? ManagerEmployeeId);

        private static IList<ServiceRequestItemDto> BuildRequestItems(
            CreateServiceRequestCommandRequest request,
            ServiceDefinition? serviceDefinition)
        {
            if (request.Items.Any())
            {
                return request.Items
                    .Where(x => !string.IsNullOrWhiteSpace(x.ItemName) && x.Quantity > 0)
                    .ToList();
            }

            if (serviceDefinition is null)
            {
                return new List<ServiceRequestItemDto>();
            }

            var quantityField = request.FieldValues
                .FirstOrDefault(x => x.FieldKey.Equals("quantity", StringComparison.OrdinalIgnoreCase));

            var quantity = int.TryParse(quantityField?.Value, out var parsedQuantity) && parsedQuantity > 0
                ? parsedQuantity
                : 1;

            return new List<ServiceRequestItemDto>
            {
                new()
                {
                    ServiceDefinitionId = serviceDefinition.Id,
                    ItemName = serviceDefinition.Name,
                    Quantity = quantity,
                    Note = request.Description
                }
            };
        }
    }
}
