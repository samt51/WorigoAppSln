using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Application.Features.EmployeeTypes.Commands.CreateEmployeeType;
using WorigoApp.Application.Features.EmployeeTypes.Commands.UpdateEmployeeType;
using WorigoApp.Application.Features.EmployeeTypes.Queries.GetAllEmployeeTypes;

namespace WorigoApp.Api.Controllers.Employees
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class EmployeeTypesController : ControllerBase
    {
        private readonly IMediator mediator;

        public EmployeeTypesController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet("{departmentId}")]
        public async Task<IActionResult> Get(int departmentId)
        {
            return Ok(await this.mediator.Send(new GetAllEmployeeTypesQueryRequest(departmentId)));
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateEmployeeTypeCommonRequest request)
        {
            return Ok(await this.mediator.Send(request));
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateEmployeeTypeCommonRequest request)
        {
            return Ok(await this.mediator.Send(request));
        }
    }
}
