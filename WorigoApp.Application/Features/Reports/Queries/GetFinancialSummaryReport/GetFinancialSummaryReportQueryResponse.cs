namespace WorigoApp.Application.Features.Reports.Queries.GetFinancialSummaryReport
{
/// <summary>
/// GetFinancialSummaryReportQueryResponse sınıfını temsil eder.
/// </summary>
public class GetFinancialSummaryReportQueryResponse
    {
/// <summary>
/// TotalRevenue değerini alır veya ayarlar.
/// </summary>
public decimal TotalRevenue { get; set; }
/// <summary>
/// TotalPurchaseCost değerini alır veya ayarlar.
/// </summary>
public decimal TotalPurchaseCost { get; set; }
/// <summary>
/// GrossProfit değerini alır veya ayarlar.
/// </summary>
public decimal GrossProfit { get; set; }
/// <summary>
/// TotalOrderCount değerini alır veya ayarlar.
/// </summary>
public int TotalOrderCount { get; set; }
/// <summary>
/// TotalOrderItemCount değerini alır veya ayarlar.
/// </summary>
public int TotalOrderItemCount { get; set; }
/// <summary>
/// AverageOrderValue değerini alır veya ayarlar.
/// </summary>
public decimal AverageOrderValue { get; set; }
/// <summary>
/// CompletedServiceRequestCount değerini alır veya ayarlar.
/// </summary>
public int CompletedServiceRequestCount { get; set; }
/// <summary>
/// AverageServiceRating değerini alır veya ayarlar.
/// </summary>
public decimal AverageServiceRating { get; set; }
    }
}
