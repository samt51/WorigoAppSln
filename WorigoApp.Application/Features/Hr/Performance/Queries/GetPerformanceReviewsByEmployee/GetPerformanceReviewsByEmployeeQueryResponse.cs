using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Performance.Queries.GetPerformanceReviewsByEmployee
{
/// <summary>
/// GetPerformanceReviewsByEmployeeQueryResponse sınıfını temsil eder.
/// </summary>
public class GetPerformanceReviewsByEmployeeQueryResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Score değerini alır veya ayarlar.
/// </summary>
public decimal Score { get; set; }
/// <summary>
/// Strengths değerini alır veya ayarlar.
/// </summary>
public string? Strengths { get; set; }
/// <summary>
/// ImprovementAreas değerini alır veya ayarlar.
/// </summary>
public string? ImprovementAreas { get; set; }
/// <summary>
/// ManagerNote değerini alır veya ayarlar.
/// </summary>
public string? ManagerNote { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public PerformanceReviewStatusEnum Status { get; set; }
/// <summary>
/// ReviewDate değerini alır veya ayarlar.
/// </summary>
public DateTime ReviewDate { get; set; }
    }
}
