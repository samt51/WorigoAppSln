using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.LeaveRequests.Commands.UpdateLeaveRequestStatus
{
    public class UpdateLeaveRequestStatusCommandRequest : IRequest<ResponseDto<UpdateLeaveRequestStatusCommandResponse>>
    {
        public int LeaveRequestId { get; set; }
        public int ActionEmployeeId { get; set; }
        public LeaveRequestStatusEnum Status { get; set; }
        public string? Note { get; set; }
        public bool IsHrAction { get; set; }
    }
}
