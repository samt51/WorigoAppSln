using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Departments.Commands.CreateDepartment;
using WorigoApp.Application.Features.Departments.Commands.UpdateDepartment;
using WorigoApp.Application.Features.Departments.Queries.GetAllDepartment;

namespace WorigoApp.Api.Controllers.Departments
{
    [Authorize(Roles = "SystemAdmin")]
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
        public async Task<Response<IList<GetAllDepartmentQueryResponse>>> GetAllAsync()
        {
            return await this.mediator.Send(new GetAllDepartmentQueryRequest());
        }
        [HttpPost]
        public async Task<Response<CreateDepartmentCommonResponse>> AddAsync(CreateDepartmentCommonRequest request)
        {
            return await this.mediator.Send(request);
        }
        [HttpPost]
        public async Task<Response<UpdateDepartmentCommonResponse>> UpdateAsync(UpdateDepartmentCommonRequest request)
        {
            return await this.mediator.Send(request);
        }
    }
}
