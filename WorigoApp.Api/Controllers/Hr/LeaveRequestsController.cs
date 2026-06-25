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
    /// <summary>
    /// LeaveRequestsController sınıfını temsil eder.
    /// </summary>
[Authorize(Roles = "SystemAdmin,HotelAdmin,HRManager,DepartmentManager,Employee")]
    public class LeaveRequestsController : BaseController
    {
        private readonly IMediator _mediator;
/// <summary>
/// LeaveRequestsController sınıfının yeni bir örneğini başlatır.
/// </summary>
public LeaveRequestsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Personelin departman mudurune ve gerekirse IK'ya izin talebi acmasini saglar.
        /// </summary>
[HttpPost]
        [SwaggerDescriptionAttirbute("Personelin departman mudurune ve gerekirse IK'ya izin talebi acmasini saglar.")]
        public async Task<ResponseDto<CreateLeaveRequestCommandResponse>> Create(CreateLeaveRequestCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Mudurun veya IK'nin izin talebi durumunu guncellemesini saglar.
        /// </summary>
[HttpPost]
        [SwaggerDescriptionAttirbute("Mudurun veya IK'nin izin talebi durumunu guncellemesini saglar.")]
        public async Task<ResponseDto<UpdateLeaveRequestStatusCommandResponse>> UpdateStatus(UpdateLeaveRequestStatusCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Personelin kendi izin taleplerini listeler.
        /// </summary>
[HttpGet("employee/{employeeId}")]
        [SwaggerDescriptionAttirbute("Personelin kendi izin taleplerini listeler.")]
        public async Task<ResponseDto<IList<GetLeaveRequestsByEmployeeQueryResponse>>> GetByEmployee(int employeeId)
        {
            return await _mediator.Send(new GetLeaveRequestsByEmployeeQueryRequest { EmployeeId = employeeId });
        }

        /// <summary>
        /// Mudure veya IK sorumlusuna dusen izin taleplerini listeler.
        /// </summary>
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
