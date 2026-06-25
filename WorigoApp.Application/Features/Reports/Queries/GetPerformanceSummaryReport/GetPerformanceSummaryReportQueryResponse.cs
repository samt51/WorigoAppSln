namespace WorigoApp.Application.Features.Reports.Queries.GetPerformanceSummaryReport
{
/// <summary>
/// GetPerformanceSummaryReportQueryResponse sınıfını temsil eder.
/// </summary>
public class GetPerformanceSummaryReportQueryResponse
    {
/// <summary>
/// TotalReviewCount değerini alır veya ayarlar.
/// </summary>
public int TotalReviewCount { get; set; }
/// <summary>
/// AverageScore değerini alır veya ayarlar.
/// </summary>
public decimal AverageScore { get; set; }
/// <summary>
/// LowScoreReviewCount değerini alır veya ayarlar.
/// </summary>
public int LowScoreReviewCount { get; set; }
/// <summary>
/// HighScoreReviewCount değerini alır veya ayarlar.
/// </summary>
public int HighScoreReviewCount { get; set; }
    }
}
