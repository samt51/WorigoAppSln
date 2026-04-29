namespace WorigoApp.Application.Features.Reports.Queries.GetAttendanceSummaryReport
{
    public class GetAttendanceSummaryReportQueryResponse
    {
        public int TotalRecordCount { get; set; }
        public int LateCount { get; set; }
        public int AbsentCount { get; set; }
        public int OnLeaveCount { get; set; }
        public int TotalOvertimeMinutes { get; set; }
    }
}
