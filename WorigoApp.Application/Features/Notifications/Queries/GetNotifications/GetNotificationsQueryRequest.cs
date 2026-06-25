using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Notifications.Queries.GetNotifications
{
/// <summary>
/// GetNotificationsQueryRequest sınıfını temsil eder.
/// </summary>
public class GetNotificationsQueryRequest : IRequest<ResponseDto<IList<GuestNotification>>>
    {
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
    }
}
