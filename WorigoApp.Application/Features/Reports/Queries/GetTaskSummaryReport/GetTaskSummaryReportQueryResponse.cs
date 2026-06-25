namespace WorigoApp.Application.Features.Reports.Queries.GetTaskSummaryReport
{
/// <summary>
/// GetTaskSummaryReportQueryResponse sınıfını temsil eder.
/// </summary>
public class GetTaskSummaryReportQueryResponse
    {
/// <summary>
/// TotalTaskCount değerini alır veya ayarlar.
/// </summary>
public int TotalTaskCount { get; set; }
/// <summary>
/// OpenTaskCount değerini alır veya ayarlar.
/// </summary>
public int OpenTaskCount { get; set; }
/// <summary>
/// InProgressTaskCount değerini alır veya ayarlar.
/// </summary>
public int InProgressTaskCount { get; set; }
/// <summary>
/// CompletedTaskCount değerini alır veya ayarlar.
/// </summary>
public int CompletedTaskCount { get; set; }
/// <summary>
/// OverdueTaskCount değerini alır veya ayarlar.
/// </summary>
public int OverdueTaskCount { get; set; }
    }
}
