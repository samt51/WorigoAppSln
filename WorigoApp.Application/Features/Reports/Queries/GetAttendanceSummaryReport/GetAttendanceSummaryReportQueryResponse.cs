namespace WorigoApp.Application.Features.Reports.Queries.GetAttendanceSummaryReport
{
/// <summary>
/// GetAttendanceSummaryReportQueryResponse sınıfını temsil eder.
/// </summary>
public class GetAttendanceSummaryReportQueryResponse
    {
/// <summary>
/// TotalRecordCount değerini alır veya ayarlar.
/// </summary>
public int TotalRecordCount { get; set; }
/// <summary>
/// LateCount değerini alır veya ayarlar.
/// </summary>
public int LateCount { get; set; }
/// <summary>
/// AbsentCount değerini alır veya ayarlar.
/// </summary>
public int AbsentCount { get; set; }
/// <summary>
/// OnLeaveCount değerini alır veya ayarlar.
/// </summary>
public int OnLeaveCount { get; set; }
/// <summary>
/// TotalOvertimeMinutes değerini alır veya ayarlar.
/// </summary>
public int TotalOvertimeMinutes { get; set; }
    }
}
