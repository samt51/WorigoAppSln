using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace WorigoApp.Api.Controllers.Service
{
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
