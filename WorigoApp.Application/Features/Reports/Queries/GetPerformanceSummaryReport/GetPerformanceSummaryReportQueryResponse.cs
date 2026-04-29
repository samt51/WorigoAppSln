namespace WorigoApp.Application.Features.Reports.Queries.GetPerformanceSummaryReport
{
    public class GetPerformanceSummaryReportQueryResponse
    {
        public int TotalReviewCount { get; set; }
        public decimal AverageScore { get; set; }
        public int LowScoreReviewCount { get; set; }
        public int HighScoreReviewCount { get; set; }
    }
}
