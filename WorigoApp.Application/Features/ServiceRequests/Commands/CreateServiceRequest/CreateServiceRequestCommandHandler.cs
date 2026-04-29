using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequests.Commands.CreateServiceRequest
{
    public class CreateServiceRequestCommandHandler : BaseHandler, IRequestHandler<CreateServiceRequestCommandRequest, ResponseDto<CreateServiceRequestCommandResponse>>
    {
        public CreateServiceRequestCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateServiceRequestCommandResponse>> Handle(CreateServiceRequestCommandRequest request, CancellationToken cancellationToken)
        {
            var guestStay = await unitOfWork.GetReadRepository<GuestStay>()
                .GetAsync(x => x.Id == request.GuestStayId && x.IsActive && !x.IsDeleted);

            if (request.CustomerId.HasValue)
            {
                await unitOfWork.GetReadRepository<Customer>()
                    .GetAsync(x => x.Id == request.CustomerId.Value && x.GuestStayId == request.GuestStayId && !x.IsDeleted);
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

            var assignment = assignments.FirstOrDefault();
            var assignedEmployee = await FindAvailableEmployeeAsync(guestStay.HotelId, assignments);

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
                DepartmentId = assignment?.DepartmentId,
                DueAt = assignment?.SlaMinutes is int sla ? now.AddMinutes(sla) : null,
                AssignedEmployeeId = assignedEmployee?.Id,
                AssignedAt = assignedEmployee is not null ? now : null,
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

            await unitOfWork.SaveAsync(cancellationToken);
            await unitOfWork.CommitAsync(cancellationToken);

            return new ResponseDto<CreateServiceRequestCommandResponse>().Success(new CreateServiceRequestCommandResponse
            {
                Id = createdRequest.Id,
                Status = createdRequest.Status,
                RequestedAt = createdRequest.RequestedAt,
                DepartmentId = createdRequest.DepartmentId,
                DueAt = createdRequest.DueAt
            });
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
                         x.IsAvailableForTask,
                    orderBy: x => x.OrderBy(y => y.LastAssignedAt ?? DateTime.MinValue));

                var availableEmployee = employees.FirstOrDefault();
                if (availableEmployee is not null)
                {
                    return availableEmployee;
                }
            }

            return null;
        }
    }
}
