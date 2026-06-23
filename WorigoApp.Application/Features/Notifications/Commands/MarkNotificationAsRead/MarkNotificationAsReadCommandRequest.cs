using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Notifications.Commands.MarkNotificationAsRead
{
    public class MarkNotificationAsReadCommandRequest : IRequest<ResponseDto<bool>>
    {
        public int Id { get; set; }
        public string SessionToken { get; set; } = string.Empty;
    }
}
