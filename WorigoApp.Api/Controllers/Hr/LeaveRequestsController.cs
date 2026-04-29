using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.LeaveRequests.Commands.CreateLeaveRequest;
using WorigoApp.Application.Features.LeaveRequests.Commands.UpdateLeaveRequestStatus;
using WorigoApp.Application.Features.LeaveRequests.Queries.GetLeaveRequestsByEmployee;
using WorigoApp.Application.Features.LeaveRequests.Queries.GetLeaveRequestsByManager;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.Hr
{
    [Authorize]
    public class LeaveRequestsController : BaseController
    {
        private readonly IMediator _mediator;

        public LeaveRequestsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [SwaggerDescriptionAttirbute("Personelin departman mudurune ve gerekirse IK'ya izin talebi acmasini saglar.")]
        public async Task<ResponseDto<CreateLeaveRequestCommandResponse>> Create(CreateLeaveRequestCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpPost]
        [SwaggerDescriptionAttirbute("Mudurun veya IK'nin izin talebi durumunu guncellemesini saglar.")]
        public async Task<ResponseDto<UpdateLeaveRequestStatusCommandResponse>> UpdateStatus(UpdateLeaveRequestStatusCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet("employee/{employeeId}")]
        [SwaggerDescriptionAttirbute("Personelin kendi izin taleplerini listeler.")]
        public async Task<ResponseDto<IList<GetLeaveRequestsByEmployeeQueryResponse>>> GetByEmployee(int employeeId)
        {
            return await _mediator.Send(new GetLeaveRequestsByEmployeeQueryRequest { EmployeeId = employeeId });
        }

        [HttpGet("manager/{managerEmployeeId}")]
        [SwaggerDescriptionAttirbute("Mudure veya IK sorumlusuna dusen izin taleplerini listeler.")]
        public async Task<ResponseDto<IList<GetLeaveRequestsByManagerQueryResponse>>> GetByManager(int managerEmployeeId, [FromQuery] bool isHrView = false)
        {
            return await _mediator.Send(new GetLeaveRequestsByManagerQueryRequest
            {
                ManagerEmployeeId = managerEmployeeId,
                IsHrView = isHrView
            });
        }
    }
}
