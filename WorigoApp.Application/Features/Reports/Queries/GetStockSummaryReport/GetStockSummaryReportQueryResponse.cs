namespace WorigoApp.Application.Features.Reports.Queries.GetStockSummaryReport
{
/// <summary>
/// GetStockSummaryReportQueryResponse sınıfını temsil eder.
/// </summary>
public class GetStockSummaryReportQueryResponse
    {
/// <summary>
/// TotalStockItemCount değerini alır veya ayarlar.
/// </summary>
public int TotalStockItemCount { get; set; }
/// <summary>
/// LowStockItemCount değerini alır veya ayarlar.
/// </summary>
public int LowStockItemCount { get; set; }
/// <summary>
/// CriticalStockItemCount değerini alır veya ayarlar.
/// </summary>
public int CriticalStockItemCount { get; set; }
/// <summary>
/// PendingStockRequestCount değerini alır veya ayarlar.
/// </summary>
public int PendingStockRequestCount { get; set; }
/// <summary>
/// TotalInventoryValue değerini alır veya ayarlar.
/// </summary>
public decimal TotalInventoryValue { get; set; }
    }
}
