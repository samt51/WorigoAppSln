using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Departments.Commands.CreateDepartment;
using WorigoApp.Application.Features.Departments.Commands.ToggleDepartmentStatus;
using WorigoApp.Application.Features.Departments.Commands.UpdateDepartment;
using WorigoApp.Application.Features.Departments.Queries.GetAllDepartment;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.Departments
{
    [Authorize(Roles = "SystemAdmin")]
    public class DepartmentController : BaseController
    {
        private readonly IMediator mediator;

        public DepartmentController(IMediator mediator) : base(mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [CachingCheckAttiribute<IList<GetAllDepartmentQueryResponse>>("departments")]
        public async Task<ResponseDto<IList<GetAllDepartmentQueryResponse>>> GetAllAsync()
        {
            return await this.mediator.Send(new GetAllDepartmentQueryRequest());
        }
        [HttpPost]
        [AddCachingToResponseAttirbute("departments")]
        public async Task<ResponseDto<CreateDepartmentCommonResponse>> AddAsync(CreateDepartmentCommonRequest request)
        {
            return await this.mediator.Send(request);
        }
        [HttpPost]
        [AddCachingToResponseAttirbute("departments")]
        public async Task<ResponseDto<UpdateDepartmentCommonResponse>> UpdateAsync(UpdateDepartmentCommonRequest request)
        {
            return await this.mediator.Send(request);
        }

        [HttpPost]
        public async Task<ResponseDto<ToggleDepartmentStatusCommandResponse>> ToggleStatus(ToggleDepartmentStatusCommandRequest request)
        {
            return await mediator.Send(request);
        }
    }
}
