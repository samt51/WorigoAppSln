using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Auth.Commands.Logout
{
/// <summary>
/// LogoutCommandRequest sınıfını temsil eder.
/// </summary>
public class LogoutCommandRequest : IRequest<ResponseDto<LogoutCommandResponse>>
    {
    }
}
