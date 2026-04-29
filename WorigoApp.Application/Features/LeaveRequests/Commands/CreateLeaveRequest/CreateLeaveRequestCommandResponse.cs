using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.LeaveRequests.Commands.CreateLeaveRequest
{
    public class CreateLeaveRequestCommandResponse
    {
        public int Id { get; set; }
        public LeaveRequestStatusEnum Status { get; set; }
        public decimal TotalDayCount { get; set; }
        public DateTime RequestedAt { get; set; }
    }
}
