using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Application.Features.Departments.Commands.CreateDepartment;
using WorigoApp.Application.Features.Departments.Commands.UpdateDepartment;
using WorigoApp.Application.Features.Departments.Queries.GetAllDepartment;

namespace WorigoApp.Api.Controllers.Departments
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IMediator mediator;
        public DepartmentsController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await this.mediator.Send(new GetAllDepartmentQueryRequest()));
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateDepartmentCommonRequest request)
        {
            return Ok(await this.mediator.Send(request));
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateDepartmentCommonRequest request)
        {
            return Ok(await this.mediator.Send(request));
        }
    }
}
