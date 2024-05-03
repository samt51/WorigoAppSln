using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Auth.Commands.Logout
{
    public class LogoutCommandRequest : IRequest<Response<LogoutCommandResponse>>
    {
    }
}
