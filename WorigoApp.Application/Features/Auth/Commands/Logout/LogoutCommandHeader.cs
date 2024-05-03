using MediatR;
using Microsoft.AspNetCore.Http;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;

namespace WorigoApp.Application.Features.Auth.Commands.Logout
{
    public class LogoutCommandHeader : BaseHandler, IRequestHandler<LogoutCommandRequest, Response<LogoutCommandResponse>>
    {
        public LogoutCommandHeader(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public Task<Response<LogoutCommandResponse>> Handle(LogoutCommandRequest request, CancellationToken cancellationToken)
        {

            return null;
        }
    }
}
