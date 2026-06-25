using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Performance.Commands.CreatePerformanceReview
{
/// <summary>
/// CreatePerformanceReviewCommandRequest sınıfını temsil eder.
/// </summary>
public class CreatePerformanceReviewCommandRequest : IRequest<ResponseDto<CreatePerformanceReviewCommandResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int EmployeeId { get; set; }
/// <summary>
/// ReviewerEmployeeId değerini alır veya ayarlar.
/// </summary>
public int ReviewerEmployeeId { get; set; }
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
