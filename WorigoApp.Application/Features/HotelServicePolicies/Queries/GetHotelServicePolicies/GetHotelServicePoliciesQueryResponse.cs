namespace WorigoApp.Application.Features.HotelServicePolicies.Queries.GetHotelServicePolicies
{
/// <summary>
/// GetHotelServicePoliciesQueryResponse sınıfını temsil eder.
/// </summary>
public class GetHotelServicePoliciesQueryResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// ServiceType değerini alır veya ayarlar.
/// </summary>
public string ServiceType { get; set; } = string.Empty;
/// <summary>
/// ServiceItemId değerini alır veya ayarlar.
/// </summary>
public int? ServiceItemId { get; set; }
/// <summary>
/// AccommodationConceptType değerini alır veya ayarlar.
/// </summary>
public string AccommodationConceptType { get; set; } = string.Empty;
/// <summary>
/// IsVisible değerini alır veya ayarlar.
/// </summary>
public bool IsVisible { get; set; }
/// <summary>
/// IsIncludedInPackage değerini alır veya ayarlar.
/// </summary>
public bool IsIncludedInPackage { get; set; }
/// <summary>
/// IsChargeable değerini alır veya ayarlar.
/// </summary>
public bool IsChargeable { get; set; }
/// <summary>
/// AllowRoomCharge değerini alır veya ayarlar.
/// </summary>
public bool AllowRoomCharge { get; set; }
/// <summary>
/// AllowOnlinePayment değerini alır veya ayarlar.
/// </summary>
public bool AllowOnlinePayment { get; set; }
/// <summary>
/// AllowOnSitePayment değerini alır veya ayarlar.
/// </summary>
public bool AllowOnSitePayment { get; set; }
/// <summary>
/// PriceOverride değerini alır veya ayarlar.
/// </summary>
public decimal? PriceOverride { get; set; }
/// <summary>
/// CurrencyCode değerini alır veya ayarlar.
/// </summary>
public string CurrencyCode { get; set; } = "TRY";
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string? Description { get; set; }
    }
}
