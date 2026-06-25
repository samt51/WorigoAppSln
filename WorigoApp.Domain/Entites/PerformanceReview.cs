using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Personelin yonetici tarafindan yapilan performans degerlendirme kaydini tutar.
    /// </summary>
    public class PerformanceReview : EntityBase
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// Hotel değerini alır veya ayarlar.
/// </summary>
public Hotel Hotel { get; set; } = null!;
/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int EmployeeId { get; set; }
/// <summary>
/// Employee değerini alır veya ayarlar.
/// </summary>
public Employee Employee { get; set; } = null!;
/// <summary>
/// ReviewerEmployeeId değerini alır veya ayarlar.
/// </summary>
public int ReviewerEmployeeId { get; set; }
/// <summary>
/// ReviewerEmployee değerini alır veya ayarlar.
/// </summary>
public Employee ReviewerEmployee { get; set; } = null!;
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int? DepartmentId { get; set; }
/// <summary>
/// Department değerini alır veya ayarlar.
/// </summary>
public Department? Department { get; set; }
/// <summary>
/// ReviewDate değerini alır veya ayarlar.
/// </summary>
public DateTime ReviewDate { get; set; } = DateTime.UtcNow;
/// <summary>
/// PeriodStartDate değerini alır veya ayarlar.
/// </summary>
public DateTime? PeriodStartDate { get; set; }
/// <summary>
/// PeriodEndDate değerini alır veya ayarlar.
/// </summary>
public DateTime? PeriodEndDate { get; set; }
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
public PerformanceReviewStatusEnum Status { get; set; } = PerformanceReviewStatusEnum.Submitted;
    }
}
