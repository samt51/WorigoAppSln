namespace WorigoApp.Application.Features.ServiceRequestRatings.Commands.CreateServiceRequestRating
{
/// <summary>
/// CreateServiceRequestRatingCommandResponse sınıfını temsil eder.
/// </summary>
public class CreateServiceRequestRatingCommandResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// ServiceRequestId değerini alır veya ayarlar.
/// </summary>
public int ServiceRequestId { get; set; }
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
/// RatedAt değerini alır veya ayarlar.
/// </summary>
public DateTime RatedAt { get; set; }
    }
}
