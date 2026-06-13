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
    [Authorize(Roles = "SystemAdmin,HotelAdmin,Management,DepartmentManager,Employee")]
    public class EmployeeController : BaseController
    {
        private readonly IMediator mediator;

        public EmployeeController(IMediator mediator) : base(mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("~/api/Employee/{hotelId}")]
        public async Task<ResponseDto<IList<GetAllEmployeesQueryResponse>>> GetAllAsync(int hotelId)
        {
            return await this.mediator.Send(new GetAllEmployeesQueryRequest(hotelId));
        }

        [HttpPost]
        [Authorize(Roles = "SystemAdmin")]
        public async Task<ResponseDto<CreateEmployeeCommonResponse>> AddAsync(CreateEmployeeCommonRequest request)
        {
            return await this.mediator.Send(request);
        }

        [HttpPost]
        [Authorize(Roles = "SystemAdmin")]
        public async Task<ResponseDto<UpdateEmployeeCommonResponse>> UpdateAsync(UpdateEmployeeCommonRequest request)
        {
            return await this.mediator.Send(request);
        }
    }
}
