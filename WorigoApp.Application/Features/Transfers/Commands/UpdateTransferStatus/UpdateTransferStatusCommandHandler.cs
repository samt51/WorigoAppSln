using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

using WorigoApp.Application.Interfaces.AutoMapper;

namespace WorigoApp.Application.Features.Transfers.Commands.UpdateTransferStatus
{
    public class UpdateTransferStatusCommandHandler : BaseHandler, IRequestHandler<UpdateTransferStatusCommandRequest, ResponseDto<UpdateTransferStatusResponse>>
    {
        public UpdateTransferStatusCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<UpdateTransferStatusResponse>> Handle(UpdateTransferStatusCommandRequest request, CancellationToken cancellationToken)
        {
            var user = await unitOfWork.GetReadRepository<Users>().FindAsync(
                x => x.Id == UserId && !x.IsDeleted,
                include: q => q.Include(x => x.Employee),
                enableTracking: false);

            if (user is null || user.Employee is null) return new ResponseDto<UpdateTransferStatusResponse>().Fail("Personel kaydı bulunamadı.", 401);

            var tracking = await unitOfWork.GetReadRepository<TransferTracking>().FindAsync(
                x => x.ServiceRequestId == request.ServiceRequestId && x.HotelId == user.Employee.HotelId && !x.IsDeleted,
                enableTracking: true);

            if (tracking is null) return new ResponseDto<UpdateTransferStatusResponse>().Fail("Transfer takip kaydı bulunamadı.", 404);

            var allowedStatuses = new[] { "Pending", "Assigned", "InProgress", "Completed", "Cancelled" };
            if (!allowedStatuses.Contains(request.Status))
            {
                return new ResponseDto<UpdateTransferStatusResponse>().Fail("Geçersiz transfer durumu.", 400);
            }

            tracking.Status = request.Status;
            tracking.ModifyDate = DateTime.Now;

            if (request.Status == "Completed")
            {
                tracking.CompletedAt = DateTime.UtcNow;
                var serviceRequest = await unitOfWork.GetReadRepository<ServiceRequest>().FindAsync(
                    x => x.Id == request.ServiceRequestId,
                    enableTracking: true);
                if (serviceRequest != null)
                {
                    serviceRequest.Status = Domain.Enums.ServiceRequestStatusEnum.Completed;
                    serviceRequest.CompletedAt = DateTime.UtcNow;
                    serviceRequest.ModifyDate = DateTime.Now;
                    await unitOfWork.GetWriteRepository<ServiceRequest>().UpdateAsync(serviceRequest);
                }
            }

            await unitOfWork.GetWriteRepository<TransferTracking>().UpdateAsync(tracking);
            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<UpdateTransferStatusResponse>().Success(new UpdateTransferStatusResponse
            {
                GuestStayId = tracking.GuestStayId,
                Status = request.Status
            });
        }
    }
}
