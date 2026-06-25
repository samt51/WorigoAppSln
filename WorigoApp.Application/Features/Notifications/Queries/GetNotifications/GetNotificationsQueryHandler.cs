using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Notifications.Queries.GetNotifications
{
/// <summary>
/// GetNotificationsQueryHandler sınıfını temsil eder.
/// </summary>
public class GetNotificationsQueryHandler : IRequestHandler<GetNotificationsQueryRequest, ResponseDto<IList<GuestNotification>>>
    {
        private readonly IUnitOfWork _unitOfWork;
/// <summary>
/// GetNotificationsQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetNotificationsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<GuestNotification>>> Handle(GetNotificationsQueryRequest request, CancellationToken cancellationToken)
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

            if (session is null) return new ResponseDto<IList<GuestNotification>>().Fail("Oturum bulunamadı veya süresi doldu.", 404);

            var notifications = await _unitOfWork.GetReadRepository<GuestNotification>().GetAllAsync(
                x => x.GuestStayId == session.GuestStayId && !x.IsDeleted && x.SentAt != null,
                orderBy: q => q.OrderByDescending(x => x.SentAt),
                enableTracking: false);

            return new ResponseDto<IList<GuestNotification>>().Success(notifications);
        }
    }
}
