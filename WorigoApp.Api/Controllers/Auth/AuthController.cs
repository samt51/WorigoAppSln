using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Auth.Commands.Login;
using WorigoApp.Application.Features.Auth.Commands.Register;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.Auth
{
    [Route("[controller]/[action]")]
    [AllowAnonymous]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator mediator;

        public AuthController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost]
        public async Task<Response<LoginCommandResponse>> Login(LoginCommandRequest request)
        {
            return await mediator.Send(request);
        }
        [HttpPost]
        public async Task<Response<RegisterCommandResponse>> Register(RegisterCommandRequest request)
        {
            return await mediator.Send(request);
        }
        [HttpPost]  
        public async Task<IActionResult> Logout() => Ok();
    }
}
