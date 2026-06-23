using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Transfers.Queries.GetTransferTracking
{
    public class GetTransferTrackingQueryHandler : IRequestHandler<GetTransferTrackingQueryRequest, ResponseDto<TransferTracking>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetTransferTrackingQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseDto<TransferTracking>> Handle(GetTransferTrackingQueryRequest request, CancellationToken cancellationToken)
        {
            var now = DateTime.UtcNow;
            var today = DateTime.Today;

            var session = await _unitOfWork.GetReadRepository<GuestSession>().FindAsync(
                x => x.SessionToken == request.SessionToken &&
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
                include: q => q.Include(x => x.GuestStay));

            if (session is null) return new ResponseDto<TransferTracking>().Fail("Oturum bulunamadı veya süresi doldu.", 404);

            var tracking = await _unitOfWork.GetReadRepository<TransferTracking>().FindAsync(
                x => x.ServiceRequestId == request.ServiceRequestId && x.GuestStayId == session.GuestStayId && !x.IsDeleted,
                include: q => q.Include(x => x.ServiceRequest),
                enableTracking: false);

            if (tracking is null) return new ResponseDto<TransferTracking>().Fail("Transfer takip kaydı bulunamadı.", 404);

            return new ResponseDto<TransferTracking>().Success(tracking);
        }
    }
}
