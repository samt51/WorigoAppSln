using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Reports.Queries.GetTopIssueReport
{
/// <summary>
/// GetTopIssueReportQueryResponse sınıfını temsil eder.
/// </summary>
public class GetTopIssueReportQueryResponse
    {
/// <summary>
/// ServiceType değerini alır veya ayarlar.
/// </summary>
public ServicesEnum ServiceType { get; set; }
/// <summary>
/// ServiceCatalogItemId değerini alır veya ayarlar.
/// </summary>
public int? ServiceCatalogItemId { get; set; }
/// <summary>
/// Title değerini alır veya ayarlar.
/// </summary>
public string Title { get; set; } = string.Empty;
/// <summary>
/// TotalCount değerini alır veya ayarlar.
/// </summary>
public int TotalCount { get; set; }
/// <summary>
/// OpenCount değerini alır veya ayarlar.
/// </summary>
public int OpenCount { get; set; }
/// <summary>
/// AverageResolutionMinutes değerini alır veya ayarlar.
/// </summary>
public decimal AverageResolutionMinutes { get; set; }
    }
}
