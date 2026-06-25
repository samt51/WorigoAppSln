using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Notifications.Commands.MarkNotificationAsRead
{
/// <summary>
/// MarkNotificationAsReadCommandRequest sınıfını temsil eder.
/// </summary>
public class MarkNotificationAsReadCommandRequest : IRequest<ResponseDto<bool>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
    }
}
