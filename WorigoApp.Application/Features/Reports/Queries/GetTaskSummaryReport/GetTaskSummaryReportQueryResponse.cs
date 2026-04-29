namespace WorigoApp.Application.Features.Reports.Queries.GetTaskSummaryReport
{
    public class GetTaskSummaryReportQueryResponse
    {
        public int TotalTaskCount { get; set; }
        public int OpenTaskCount { get; set; }
        public int InProgressTaskCount { get; set; }
        public int CompletedTaskCount { get; set; }
        public int OverdueTaskCount { get; set; }
    }
}
