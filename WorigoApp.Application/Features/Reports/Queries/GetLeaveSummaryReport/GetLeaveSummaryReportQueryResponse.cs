namespace WorigoApp.Application.Features.Reports.Queries.GetLeaveSummaryReport
{
/// <summary>
/// GetLeaveSummaryReportQueryResponse sınıfını temsil eder.
/// </summary>
public class GetLeaveSummaryReportQueryResponse
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
/// TotalLeaveRequestCount değerini alır veya ayarlar.
/// </summary>
public int TotalLeaveRequestCount { get; set; }
/// <summary>
/// PendingLeaveRequestCount değerini alır veya ayarlar.
/// </summary>
public int PendingLeaveRequestCount { get; set; }
/// <summary>
/// ApprovedLeaveRequestCount değerini alır veya ayarlar.
/// </summary>
public int ApprovedLeaveRequestCount { get; set; }
/// <summary>
/// TotalRequestedLeaveDays değerini alır veya ayarlar.
/// </summary>
public decimal TotalRequestedLeaveDays { get; set; }
    }
}
