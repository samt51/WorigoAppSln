using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.EmployeeTypes.Commands.CreateEmployeeType;
using WorigoApp.Application.Features.EmployeeTypes.Commands.UpdateEmployeeType;
using WorigoApp.Application.Features.EmployeeTypes.Queries.GetAllEmployeeTypes;

namespace WorigoApp.Api.Controllers.Employees
{
    [Authorize(Roles = "SystemAdmin")]
    public class EmployeeTypesController : BaseController
    {
        private readonly IMediator mediator;
        public EmployeeTypesController(IMediator mediator) : base(mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{departmentId}")]
        public async Task<Response<IList<GetAllEmployeeTypesQueryResponse>>> GetAllAsync(int departmentId)
        {
            return await this.mediator.Send(new GetAllEmployeeTypesQueryRequest(departmentId));
        }
        [HttpPost]
        public async Task<Response<CreateEmployeeTypeCommonResponse>> AddAsync(CreateEmployeeTypeCommonRequest request)
        {
            return await this.mediator.Send(request);
        }
        [HttpPost]
        public async Task<Response<UpdateEmployeeTypeCommonResponse>> UpdateAsync(UpdateEmployeeTypeCommonRequest request)
        {
            return await this.mediator.Send(request);
        }
    }
}
