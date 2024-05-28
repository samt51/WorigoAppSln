using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Employees.Commands.CreateEmployee;
using WorigoApp.Application.Features.Employees.Commands.UpdateEmployee;
using WorigoApp.Application.Features.Employees.Queries.GetAllEmployees;

namespace WorigoApp.Api.Controllers.Employees
{
    [Authorize(Roles = "SystemAdmin")]
    public class EmployeeController : BaseController
    {
        private readonly IMediator mediator;

        public EmployeeController(IMediator mediator) : base(mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{hotelId}")]
        public async Task<Response<IList<GetAllEmployeesQueryResponse>>> GetAllAsync(int hotelId)
        {
            return await this.mediator.Send(new GetAllEmployeesQueryRequest(hotelId));
        }
        [HttpPost]
        public async Task<Response<CreateEmployeeCommonResponse>> AddAsync(CreateEmployeeCommonRequest request)
        {
            return await this.mediator.Send(request);
        }
        [HttpPost]
        public async Task<Response<UpdateEmployeeCommonResponse>> UpdateAsync(UpdateEmployeeCommonRequest request)
        {
            return await this.mediator.Send(request);
        }
    }
}
