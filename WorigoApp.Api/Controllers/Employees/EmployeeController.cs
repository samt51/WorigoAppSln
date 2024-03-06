using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Application.Features.Employees.Commands.CreateEmployee;

namespace WorigoApp.Api.Controllers.Employees
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator mediator;

        public EmployeeController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> NewEmployee(CreateEmployeeCommonRequest request)
        {
            var response = await mediator.Send(request);
            return Ok(response);
        }
    }
}
