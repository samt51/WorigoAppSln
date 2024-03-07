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
        public IActionResult Get(GetAllDepartmentQueryRequest request)
        {
            return Ok(this.mediator.Send(request));
        }
        [HttpPost]
        public IActionResult Post(CreateDepartmentCommonRequest request)
        {
            return Ok(this.mediator.Send(request));
        }
        [HttpPost]
        public IActionResult Update(UpdateDepartmentCommonRequest request)
        {
            return Ok(this.mediator.Send(request));
        }
    }
}
