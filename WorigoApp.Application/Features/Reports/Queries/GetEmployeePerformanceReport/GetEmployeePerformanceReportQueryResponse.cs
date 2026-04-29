namespace WorigoApp.Application.Features.Reports.Queries.GetEmployeePerformanceReport
{
    public class GetEmployeePerformanceReportQueryResponse
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public string? EmployeeTypeName { get; set; }
        public int TotalAssignedRequestCount { get; set; }
        public int CompletedRequestCount { get; set; }
        public decimal CompletionRate { get; set; }
        public decimal AverageResolutionMinutes { get; set; }
        public decimal AverageRating { get; set; }
        public int CreatedStockRequestCount { get; set; }
    }
}
