using System.Collections.Generic;

namespace WorigoApp.Application.Features.Reports.Queries.GetHousekeepingReport
{
/// <summary>
/// GetHousekeepingReportQueryResponse sınıfını temsil eder.
/// </summary>
public class GetHousekeepingReportQueryResponse
    {
/// <summary>
/// TotalTasksCount değerini alır veya ayarlar.
/// </summary>
public int TotalTasksCount { get; set; }
/// <summary>
/// CompletedTasksCount değerini alır veya ayarlar.
/// </summary>
public int CompletedTasksCount { get; set; }
/// <summary>
/// TaskCompletionRate değerini alır veya ayarlar.
/// </summary>
public decimal TaskCompletionRate { get; set; }
/// <summary>
/// AverageCleaningTimeMinutes değerini alır veya ayarlar.
/// </summary>
public decimal AverageCleaningTimeMinutes { get; set; }
/// <summary>
/// TotalServiceRequestsCount değerini alır veya ayarlar.
/// </summary>
public int TotalServiceRequestsCount { get; set; }
/// <summary>
/// CompletedServiceRequestsCount değerini alır veya ayarlar.
/// </summary>
public int CompletedServiceRequestsCount { get; set; }
/// <summary>
/// AverageServiceRequestRating değerini alır veya ayarlar.
/// </summary>
public decimal AverageServiceRequestRating { get; set; }
/// <summary>
/// HousekeeperPerformance değerini alır veya ayarlar.
/// </summary>
public List<HousekeeperPerformanceDto> HousekeeperPerformance { get; set; } = new List<HousekeeperPerformanceDto>();
    }

/// <summary>
/// HousekeeperPerformanceDto sınıfını temsil eder.
/// </summary>
public class HousekeeperPerformanceDto
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
/// AssignedTasksCount değerini alır veya ayarlar.
/// </summary>
public int AssignedTasksCount { get; set; }
/// <summary>
/// CompletedTasksCount değerini alır veya ayarlar.
/// </summary>
public int CompletedTasksCount { get; set; }
/// <summary>
/// AverageCleaningTimeMinutes değerini alır veya ayarlar.
/// </summary>
public decimal AverageCleaningTimeMinutes { get; set; }
    }
}
