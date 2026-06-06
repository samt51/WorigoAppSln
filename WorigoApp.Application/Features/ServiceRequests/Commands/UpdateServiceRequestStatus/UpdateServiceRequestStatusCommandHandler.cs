using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequests.Commands.UpdateServiceRequestStatus
{
    public class UpdateServiceRequestStatusCommandHandler : BaseHandler, IRequestHandler<UpdateServiceRequestStatusCommandRequest, ResponseDto<UpdateServiceRequestStatusCommandResponse>>
    {
        public UpdateServiceRequestStatusCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<UpdateServiceRequestStatusCommandResponse>> Handle(UpdateServiceRequestStatusCommandRequest request, CancellationToken cancellationToken)
        {
            var serviceRequest = await unitOfWork.GetReadRepository<ServiceRequest>()
                .GetAsync(x => x.Id == request.ServiceRequestId && !x.IsDeleted, enableTracking: true);

            if (request.AssignedEmployeeId.HasValue)
            {
                await unitOfWork.GetReadRepository<Employee>()
                    .GetAsync(x => x.Id == request.AssignedEmployeeId.Value && !x.IsDeleted && x.IsActive);

                serviceRequest.AssignedEmployeeId = request.AssignedEmployeeId;
                serviceRequest.AssignedAt ??= DateTime.UtcNow;
            }

            var now = DateTime.UtcNow;
            var oldStatus = serviceRequest.Status;
            serviceRequest.Status = request.NewStatus;

            switch (request.NewStatus)
            {
                case ServiceRequestStatusEnum.Assigned:
                    serviceRequest.AssignedAt ??= now;
                    break;
                case ServiceRequestStatusEnum.InProgress:
                    serviceRequest.StartedAt ??= now;
                    break;
                case ServiceRequestStatusEnum.Completed:
                    serviceRequest.CompletedAt = now;
                    break;
                case ServiceRequestStatusEnum.Closed:
                    serviceRequest.ClosedAt = now;
                    break;
            }

            await unitOfWork.OpenTransactionAsync(cancellationToken);
            await unitOfWork.GetWriteRepository<ServiceRequest>().UpdateAsync(serviceRequest);
            await unitOfWork.SaveAsync(cancellationToken);

            await unitOfWork.GetWriteRepository<ServiceRequestHistory>().AddAsync(new ServiceRequestHistory
            {
                ServiceRequestId = serviceRequest.Id,
                OldStatus = oldStatus,
                NewStatus = request.NewStatus,
                ChangedByUserId = request.ChangedByUserId,
                ChangedAt = now,
                Note = request.Note
            });

            await unitOfWork.SaveAsync(cancellationToken);
            await unitOfWork.CommitAsync(cancellationToken);

            return new ResponseDto<UpdateServiceRequestStatusCommandResponse>().Success(new UpdateServiceRequestStatusCommandResponse
            {
                Id = serviceRequest.Id,
                Status = serviceRequest.Status,
                AssignedAt = serviceRequest.AssignedAt,
                StartedAt = serviceRequest.StartedAt,
                CompletedAt = serviceRequest.CompletedAt,
                ClosedAt = serviceRequest.ClosedAt,
                HotelId = serviceRequest.HotelId,
                DepartmentId = serviceRequest.DepartmentId,
                AssignedEmployeeId = serviceRequest.AssignedEmployeeId,
                GuestStayId = serviceRequest.GuestStayId
            });
        }
    }
}
