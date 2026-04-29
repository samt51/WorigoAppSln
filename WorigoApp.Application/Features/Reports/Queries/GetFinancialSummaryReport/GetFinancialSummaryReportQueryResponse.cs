namespace WorigoApp.Application.Features.Reports.Queries.GetFinancialSummaryReport
{
    public class GetFinancialSummaryReportQueryResponse
    {
        public decimal TotalRevenue { get; set; }
        public decimal TotalPurchaseCost { get; set; }
        public decimal GrossProfit { get; set; }
        public int TotalOrderCount { get; set; }
        public int TotalOrderItemCount { get; set; }
        public decimal AverageOrderValue { get; set; }
        public int CompletedServiceRequestCount { get; set; }
        public decimal AverageServiceRating { get; set; }
    }
}
