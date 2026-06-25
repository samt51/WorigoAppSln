using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Auth.Commands.Login;
using WorigoApp.Application.Features.Auth.Commands.Register;

namespace WorigoApp.Api.Controllers.Auth
{
    /// <summary>
    /// AuthController sınıfını temsil eder.
    /// </summary>
[AllowAnonymous]
    public class AuthController : BaseController
    {
        private readonly IMediator mediator;
/// <summary>
/// AuthController sınıfının yeni bir örneğini başlatır.
/// </summary>
public AuthController(IMediator mediator) : base(mediator)
        {
            this.mediator = mediator;

        }

        /// <summary>
        /// Login işlemini gerçekleştirir.
        /// </summary>
[HttpPost]
        public async Task<ResponseDto<LoginCommandResponse>> Login(LoginCommandRequest request)
        {
            return await mediator.Send(request);
        }

        /// <summary>
        /// Register işlemini gerçekleştirir.
        /// </summary>
[HttpPost]
        public async Task<ResponseDto<RegisterCommandResponse>> Register(RegisterCommandRequest request)
        {
            return await mediator.Send(request);
        }
        /// <summary>
        /// Logout işlemini gerçekleştirir.
        /// </summary>
[HttpPost]
        public async Task<IActionResult> Logout() => Ok();

        /// <summary>
        /// Localization işlemini gerçekleştirir.
        /// </summary>
[HttpGet]
        public async Task<IActionResult> Localization()
        {
            return Ok();
        }
    }
}
