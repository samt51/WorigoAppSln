using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace WorigoApp.Api.Controllers.Service
{
    [Authorize(Roles = "SystemAdmin")]
    [Route("[controller]/[action]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServiceController(IMediator mediator)
        {
            this._mediator = mediator;
        }
      
    }
}
