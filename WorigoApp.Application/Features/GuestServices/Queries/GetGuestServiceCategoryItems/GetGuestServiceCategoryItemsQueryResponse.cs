using WorigoApp.Application.Features.GuestServices.Dtos;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.GuestServices.Queries.GetGuestServiceCategoryItems
{
/// <summary>
/// GetGuestServiceCategoryItemsQueryResponse sınıfını temsil eder.
/// </summary>
public class GetGuestServiceCategoryItemsQueryResponse
    {
/// <summary>
/// ServiceDefinitionId değerini alır veya ayarlar.
/// </summary>
public int? ServiceDefinitionId { get; set; }
/// <summary>
/// ServiceCategoryId değerini alır veya ayarlar.
/// </summary>
public int? ServiceCategoryId { get; set; }
/// <summary>
/// ServiceCategoryName değerini alır veya ayarlar.
/// </summary>
public string? ServiceCategoryName { get; set; }
/// <summary>
/// ServiceType değerini alır veya ayarlar.
/// </summary>
public string ServiceType { get; set; } = string.Empty;
/// <summary>
/// ServiceItemId değerini alır veya ayarlar.
/// </summary>
public int ServiceItemId { get; set; }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; } = string.Empty;
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string? Description { get; set; }
/// <summary>
/// ImageUrl değerini alır veya ayarlar.
/// </summary>
public string? ImageUrl { get; set; }
/// <summary>
/// IsChargeable değerini alır veya ayarlar.
/// </summary>
public bool IsChargeable { get; set; }
/// <summary>
/// IsIncludedInPackage değerini alır veya ayarlar.
/// </summary>
public bool IsIncludedInPackage { get; set; }
/// <summary>
/// Price değerini alır veya ayarlar.
/// </summary>
public decimal Price { get; set; }
/// <summary>
/// CurrencyCode değerini alır veya ayarlar.
/// </summary>
public string CurrencyCode { get; set; } = "TRY";
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
/// SupportsFreeText değerini alır veya ayarlar.
/// </summary>
public bool SupportsFreeText { get; set; }
/// <summary>
/// RequiresAppointment değerini alır veya ayarlar.
/// </summary>
public bool RequiresAppointment { get; set; }
/// <summary>
/// EstimatedDurationMinutes değerini alır veya ayarlar.
/// </summary>
public int? EstimatedDurationMinutes { get; set; }
/// <summary>
/// DisplayOrder değerini alır veya ayarlar.
/// </summary>
public int DisplayOrder { get; set; }
/// <summary>
/// FlowUiType değerini alır veya ayarlar.
/// </summary>
public ServiceFlowUiTypeEnum FlowUiType { get; set; }
/// <summary>
/// OpeningMessageType değerini alır veya ayarlar.
/// </summary>
public ConversationMessageTypeEnum OpeningMessageType { get; set; }
/// <summary>
/// OpeningMessage değerini alır veya ayarlar.
/// </summary>
public string OpeningMessage { get; set; } = string.Empty;
/// <summary>
/// OpeningPayloadJson değerini alır veya ayarlar.
/// </summary>
public string? OpeningPayloadJson { get; set; }
/// <summary>
/// Fields değerini alır veya ayarlar.
/// </summary>
public IList<ServiceDefinitionFieldDto> Fields { get; set; } = new List<ServiceDefinitionFieldDto>();
    }
}
