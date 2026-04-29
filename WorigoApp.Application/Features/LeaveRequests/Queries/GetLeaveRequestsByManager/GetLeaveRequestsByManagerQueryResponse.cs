using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.LeaveRequests.Queries.GetLeaveRequestsByManager
{
    public class GetLeaveRequestsByManagerQueryResponse
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public string? DepartmentName { get; set; }
        public string Title { get; set; } = string.Empty;
        public LeaveRequestTypeEnum LeaveType { get; set; }
        public LeaveRequestStatusEnum Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalDayCount { get; set; }
        public DateTime RequestedAt { get; set; }
    }
}
