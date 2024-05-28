using MediatR;
using Microsoft.AspNetCore.Authorization;
using WorigoApp.Api.Controllers.CommonBase;

namespace WorigoApp.Api.Controllers.Service
{
    [Authorize(Roles = "SystemAdmin")]
    public class ServiceController : BaseController
    {
        private readonly IMediator _mediator;

        public ServiceController(IMediator mediator) : base(mediator)
        {
            this._mediator = mediator;
        }
    }
}
