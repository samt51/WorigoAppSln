using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.LeaveRequests.Commands.UpdateLeaveRequestStatus
{
    public class UpdateLeaveRequestStatusCommandResponse
    {
        public int Id { get; set; }
        public LeaveRequestStatusEnum Status { get; set; }
        public DateTime? ManagerActionAt { get; set; }
        public DateTime? HrActionAt { get; set; }
    }
}
