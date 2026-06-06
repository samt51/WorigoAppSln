using WorigoApp.Application.Features.EmployeeTypes.Queries.GetByIdEmployeeType;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.EmployeeTypes.Commands.CreateEmployeeType;
using WorigoApp.Application.Features.EmployeeTypes.Commands.ToggleEmployeeTypeStatus;
using WorigoApp.Application.Features.EmployeeTypes.Commands.UpdateEmployeeType;
using WorigoApp.Application.Features.EmployeeTypes.Queries.GetAllEmployeeTypes;

namespace WorigoApp.Api.Controllers.Employees
{
    [Authorize(Roles = "SystemAdmin")]
    public class EmployeeTypeController : BaseController
    {
        private readonly IMediator mediator;
        public EmployeeTypeController(IMediator mediator) : base(mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{departmentId}")]
        public async Task<ResponseDto<IList<GetAllEmployeeTypesQueryResponse>>> GetAllAsync(int departmentId)
        {
            return await this.mediator.Send(new GetAllEmployeeTypesQueryRequest(departmentId));
        }
        [HttpPost]
        public async Task<ResponseDto<CreateEmployeeTypeCommonResponse>> AddAsync(CreateEmployeeTypeCommonRequest request)
        {
            return await this.mediator.Send(request);
        }
        [HttpPost]
        public async Task<ResponseDto<UpdateEmployeeTypeCommonResponse>> UpdateAsync(UpdateEmployeeTypeCommonRequest request)
        {
            return await this.mediator.Send(request);
        }

        [HttpPost]
        public async Task<ResponseDto<ToggleEmployeeTypeStatusCommandResponse>> ToggleStatus(ToggleEmployeeTypeStatusCommandRequest request)
        {
            return await mediator.Send(request);
        }

        [HttpGet("{id}")]
        public async Task<ResponseDto<GetByIdEmployeeTypeQueryResponse>> GetByIdAsync(int id)
        {
            return await mediator.Send(new GetByIdEmployeeTypeQueryRequest(id));
        }
    }
}

