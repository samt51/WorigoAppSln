using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ServiceRequestRatings.Commands.RateOrder
{
/// <summary>
/// RateOrderCommandRequest sınıfını temsil eder.
/// </summary>
public class RateOrderCommandRequest : IRequest<ResponseDto<bool>>
    {
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
/// <summary>
/// OrderId değerini alır veya ayarlar.
/// </summary>
public int OrderId { get; set; }
/// <summary>
/// SpeedScore değerini alır veya ayarlar.
/// </summary>
public decimal SpeedScore { get; set; }
/// <summary>
/// QualityScore değerini alır veya ayarlar.
/// </summary>
public decimal QualityScore { get; set; }
/// <summary>
/// StaffScore değerini alır veya ayarlar.
/// </summary>
public decimal StaffScore { get; set; }
/// <summary>
/// OverallScore değerini alır veya ayarlar.
/// </summary>
public decimal? OverallScore { get; set; }
/// <summary>
/// Comment değerini alır veya ayarlar.
/// </summary>
public string? Comment { get; set; }
    }
}
