namespace WorigoApp.Application.Features.Reports.Queries.GetEmployeePerformanceReport
{
/// <summary>
/// GetEmployeePerformanceReportQueryResponse sınıfını temsil eder.
/// </summary>
public class GetEmployeePerformanceReportQueryResponse
    {
/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int EmployeeId { get; set; }
/// <summary>
/// EmployeeName değerini alır veya ayarlar.
/// </summary>
public string EmployeeName { get; set; } = string.Empty;
/// <summary>
/// EmployeeTypeName değerini alır veya ayarlar.
/// </summary>
public string? EmployeeTypeName { get; set; }
/// <summary>
/// TotalAssignedRequestCount değerini alır veya ayarlar.
/// </summary>
public int TotalAssignedRequestCount { get; set; }
/// <summary>
/// CompletedRequestCount değerini alır veya ayarlar.
/// </summary>
public int CompletedRequestCount { get; set; }
/// <summary>
/// CompletionRate değerini alır veya ayarlar.
/// </summary>
public decimal CompletionRate { get; set; }
/// <summary>
/// AverageResolutionMinutes değerini alır veya ayarlar.
/// </summary>
public decimal AverageResolutionMinutes { get; set; }
/// <summary>
/// AverageRating değerini alır veya ayarlar.
/// </summary>
public decimal AverageRating { get; set; }
/// <summary>
/// CreatedStockRequestCount değerini alır veya ayarlar.
/// </summary>
public int CreatedStockRequestCount { get; set; }
    }
}
