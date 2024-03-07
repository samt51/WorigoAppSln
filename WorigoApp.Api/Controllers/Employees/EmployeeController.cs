using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Application.Features.Employees.Commands.CreateEmployee;
using WorigoApp.Application.Features.Employees.Queries.GetAllEmployees;
using WorigoApp.Application.Features.EmployeeTypes.Commands.UpdateEmployeeType;

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
        [HttpGet]
        public IActionResult Get(GetAllEmployeesQueryRequest request)
        {
            return Ok(this.mediator.Send(request));
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateEmployeeCommonRequest request)
        {
            var response = await mediator.Send(request);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateEmployeeTypeCommonRequest request)
        {
            var response = await mediator.Send(request);
            return Ok(response);
        }
    }
}
