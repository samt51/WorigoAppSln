namespace WorigoApp.Application.Features.Reports.Queries.GetLeaveSummaryReport
{
    public class GetLeaveSummaryReportQueryResponse
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public int TotalLeaveRequestCount { get; set; }
        public int PendingLeaveRequestCount { get; set; }
        public int ApprovedLeaveRequestCount { get; set; }
        public decimal TotalRequestedLeaveDays { get; set; }
    }
}
