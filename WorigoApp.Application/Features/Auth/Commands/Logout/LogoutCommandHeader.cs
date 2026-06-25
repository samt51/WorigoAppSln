using MediatR;
using Microsoft.AspNetCore.Http;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;

namespace WorigoApp.Application.Features.Auth.Commands.Logout
{
/// <summary>
/// LogoutCommandHeader sınıfını temsil eder.
/// </summary>
public class LogoutCommandHeader : BaseHandler, IRequestHandler<LogoutCommandRequest, ResponseDto<LogoutCommandResponse>>
    {
/// <summary>
/// LogoutCommandHeader sınıfının yeni bir örneğini başlatır.
/// </summary>
public LogoutCommandHeader(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public Task<ResponseDto<LogoutCommandResponse>> Handle(LogoutCommandRequest request, CancellationToken cancellationToken)
        {

            return null;
        }
    }
}
