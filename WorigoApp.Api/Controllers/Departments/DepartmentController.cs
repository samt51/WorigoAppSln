using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Departments.Commands.CreateDepartment;
using WorigoApp.Application.Features.Departments.Commands.UpdateDepartment;
using WorigoApp.Application.Features.Departments.Queries.GetAllDepartment;
using WorigoApp.Application.Features.Departments.Queries.GetByIdDepartment;

namespace WorigoApp.Api.Controllers.Departments
{
    [Authorize(Roles = "SystemAdmin,HotelAdmin,Management,DepartmentManager,Employee")]
    public class DepartmentController : BaseController
    {
        private readonly IMediator _mediator;
        public DepartmentController(IMediator mediator) : base(mediator) { _mediator = mediator; }

        [HttpGet]
        public async Task<ResponseDto<IList<GetAllDepartmentQueryResponse>>> GetAllAsync() => await _mediator.Send(new GetAllDepartmentQueryRequest());

        [HttpPost]
        [Authorize(Roles = "SystemAdmin")]
        public async Task<ResponseDto<CreateDepartmentCommonResponse>> AddAsync(CreateDepartmentCommonRequest request) => await _mediator.Send(request);

        [HttpPost]
        [Authorize(Roles = "SystemAdmin")]
        public async Task<ResponseDto<UpdateDepartmentCommonResponse>> UpdateAsync(UpdateDepartmentCommonRequest request) => await _mediator.Send(request);

        [HttpGet("{id}")]
        public async Task<ResponseDto<GetByIdDepartmentQueryResponse>> GetByIdAsync(int id) => await _mediator.Send(new GetByIdDepartmentQueryRequest(id));
    }
}
