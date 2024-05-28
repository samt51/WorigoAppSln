using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WorigoApp.Api.Controllers.CommonBase
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        private readonly IMediator mediator;

        public BaseController(IMediator mediator)
        {
            this.mediator = mediator;
        }
         
    }
}
