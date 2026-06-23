using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Notifications.Commands.MarkNotificationAsRead
{
    public class MarkNotificationAsReadCommandHandler : IRequestHandler<MarkNotificationAsReadCommandRequest, ResponseDto<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public MarkNotificationAsReadCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseDto<bool>> Handle(MarkNotificationAsReadCommandRequest request, CancellationToken cancellationToken)
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

            if (session is null) return new ResponseDto<bool>().Fail("Oturum bulunamadı veya süresi doldu.", 404);

            var notification = await _unitOfWork.GetReadRepository<GuestNotification>().FindAsync(
                x => x.Id == request.Id && x.GuestStayId == session.GuestStayId && !x.IsDeleted,
                enableTracking: true);

            if (notification is null) return new ResponseDto<bool>().Fail("Bildirim bulunamadı.", 404);

            notification.IsRead = true;
            notification.ReadAt = DateTime.UtcNow;
            notification.ModifyDate = DateTime.Now;

            await _unitOfWork.GetWriteRepository<GuestNotification>().UpdateAsync(notification);
            await _unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<bool>().Success(true);
        }
    }
}
