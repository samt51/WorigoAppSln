namespace WorigoApp.Application.Features.ServiceRequestRatings.Queries.GetRatingsByServiceRequest
{
/// <summary>
/// GetRatingsByServiceRequestQueryResponse sınıfını temsil eder.
/// </summary>
public class GetRatingsByServiceRequestQueryResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
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
/// <summary>
/// RatedAt değerini alır veya ayarlar.
/// </summary>
public DateTime RatedAt { get; set; }
    }
}
