using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.HotelServicePolicies.Commands.UpsertHotelServicePolicy
{
/// <summary>
/// UpsertHotelServicePolicyCommandRequest sınıfını temsil eder.
/// </summary>
public class UpsertHotelServicePolicyCommandRequest : IRequest<ResponseDto<UpsertHotelServicePolicyCommandResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// ServiceType değerini alır veya ayarlar.
/// </summary>
public ServicesEnum ServiceType { get; set; }
/// <summary>
/// ServiceItemId değerini alır veya ayarlar.
/// </summary>
public int? ServiceItemId { get; set; }
/// <summary>
/// AccommodationConceptType değerini alır veya ayarlar.
/// </summary>
public AccommodationConceptTypeEnum AccommodationConceptType { get; set; }
/// <summary>
/// IsVisible değerini alır veya ayarlar.
/// </summary>
public bool IsVisible { get; set; } = true;
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
public bool AllowRoomCharge { get; set; } = true;
/// <summary>
/// AllowOnlinePayment değerini alır veya ayarlar.
/// </summary>
public bool AllowOnlinePayment { get; set; }
/// <summary>
/// AllowOnSitePayment değerini alır veya ayarlar.
/// </summary>
public bool AllowOnSitePayment { get; set; } = true;
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
