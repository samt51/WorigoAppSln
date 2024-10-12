using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Application.Features.Services.Commands.CreateService;

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
        [HttpPost]
        public async Task<IActionResult> Create(CreateServiceCommandRequest request)
        {
            return Ok( await _mediator.Send(request));
           
        }
    }
}
