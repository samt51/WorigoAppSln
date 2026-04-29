using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.LeaveRequests.Queries.GetLeaveRequestsByEmployee
{
    public class GetLeaveRequestsByEmployeeQueryResponse
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public LeaveRequestTypeEnum LeaveType { get; set; }
        public LeaveRequestStatusEnum Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalDayCount { get; set; }
        public string? ManagerNote { get; set; }
        public string? HrNote { get; set; }
    }
}
