namespace WorigoApp.Application.Features.Reports.Queries.GetDepartmentPerformanceReport
{
/// <summary>
/// GetDepartmentPerformanceReportQueryResponse sınıfını temsil eder.
/// </summary>
public class GetDepartmentPerformanceReportQueryResponse
    {
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int DepartmentId { get; set; }
/// <summary>
/// DepartmentName değerini alır veya ayarlar.
/// </summary>
public string DepartmentName { get; set; } = string.Empty;
/// <summary>
/// TotalRequestCount değerini alır veya ayarlar.
/// </summary>
public int TotalRequestCount { get; set; }
/// <summary>
/// OpenRequestCount değerini alır veya ayarlar.
/// </summary>
public int OpenRequestCount { get; set; }
/// <summary>
/// CompletedRequestCount değerini alır veya ayarlar.
/// </summary>
public int CompletedRequestCount { get; set; }
/// <summary>
/// AverageResolutionMinutes değerini alır veya ayarlar.
/// </summary>
public decimal AverageResolutionMinutes { get; set; }
/// <summary>
/// AverageRating değerini alır veya ayarlar.
/// </summary>
public decimal AverageRating { get; set; }
/// <summary>
/// PendingStockRequestCount değerini alır veya ayarlar.
/// </summary>
public int PendingStockRequestCount { get; set; }
/// <summary>
/// LowStockItemCount değerini alır veya ayarlar.
/// </summary>
public int LowStockItemCount { get; set; }
    }
}
