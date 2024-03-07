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
        [HttpGet("{id}")]
        public IActionResult Get(int departmentId)
        {
            return Ok(this.mediator.Send(new GetAllEmployeeTypesQueryRequest(departmentId)));
        }
        [HttpPost]
        public IActionResult Post(CreateEmployeeTypeCommonRequest request)
        {
            return Ok(this.mediator.Send(request));
        }
        [HttpPost]
        public IActionResult Update(UpdateEmployeeTypeCommonRequest request)
        {
            return Ok(this.mediator.Send(request));
        }
    }
}
