using MediatR;
using Microsoft.AspNetCore.Authorization;
using WorigoApp.Api.Controllers.CommonBase;

namespace WorigoApp.Api.Controllers.Service
{
    /// <summary>
    /// ServiceController sınıfını temsil eder.
    /// </summary>
[Authorize(Roles = "SystemAdmin")]
    public class ServiceController : BaseController
    {
        private readonly IMediator _mediator;
/// <summary>
/// ServiceController sınıfının yeni bir örneğini başlatır.
/// </summary>
public ServiceController(IMediator mediator) : base(mediator)
        {
            this._mediator = mediator;
        }
    }
}
