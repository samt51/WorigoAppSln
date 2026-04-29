namespace WorigoApp.Application.Features.Reports.Queries.GetStockSummaryReport
{
    public class GetStockSummaryReportQueryResponse
    {
        public int TotalStockItemCount { get; set; }
        public int LowStockItemCount { get; set; }
        public int CriticalStockItemCount { get; set; }
        public int PendingStockRequestCount { get; set; }
        public decimal TotalInventoryValue { get; set; }
    }
}
