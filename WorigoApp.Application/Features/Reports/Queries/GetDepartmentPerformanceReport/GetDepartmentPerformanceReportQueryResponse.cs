namespace WorigoApp.Application.Features.Reports.Queries.GetDepartmentPerformanceReport
{
    public class GetDepartmentPerformanceReportQueryResponse
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public int TotalRequestCount { get; set; }
        public int OpenRequestCount { get; set; }
        public int CompletedRequestCount { get; set; }
        public decimal AverageResolutionMinutes { get; set; }
        public decimal AverageRating { get; set; }
        public int PendingStockRequestCount { get; set; }
        public int LowStockItemCount { get; set; }
    }
}
