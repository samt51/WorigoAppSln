using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ServiceRequestRatings.Commands.CreateServiceRequestRating
{
/// <summary>
/// CreateServiceRequestRatingCommandRequest sınıfını temsil eder.
/// </summary>
public class CreateServiceRequestRatingCommandRequest : IRequest<ResponseDto<CreateServiceRequestRatingCommandResponse>>
    {
/// <summary>
/// ServiceRequestId değerini alır veya ayarlar.
/// </summary>
public int ServiceRequestId { get; set; }
/// <summary>
/// CustomerId değerini alır veya ayarlar.
/// </summary>
public int? CustomerId { get; set; }
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
/// Comment değerini alır veya ayarlar.
/// </summary>
public string? Comment { get; set; }
    }
}
