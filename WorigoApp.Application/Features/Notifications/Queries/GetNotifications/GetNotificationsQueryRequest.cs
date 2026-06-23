using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Notifications.Queries.GetNotifications
{
    public class GetNotificationsQueryRequest : IRequest<ResponseDto<IList<GuestNotification>>>
    {
        public string SessionToken { get; set; } = string.Empty;
    }
}
