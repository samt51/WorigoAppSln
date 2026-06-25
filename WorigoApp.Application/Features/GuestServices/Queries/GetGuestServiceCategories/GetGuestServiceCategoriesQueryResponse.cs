using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.GuestServices.Queries.GetGuestServiceCategories
{
/// <summary>
/// GetGuestServiceCategoriesQueryResponse sınıfını temsil eder.
/// </summary>
public class GetGuestServiceCategoriesQueryResponse
    {
/// <summary>
/// ServiceCategoryId değerini alır veya ayarlar.
/// </summary>
public int? ServiceCategoryId { get; set; }
/// <summary>
/// ServiceType değerini alır veya ayarlar.
/// </summary>
public string ServiceType { get; set; } = string.Empty;
/// <summary>
/// DisplayName değerini alır veya ayarlar.
/// </summary>
public string DisplayName { get; set; } = string.Empty;
/// <summary>
/// ItemCount değerini alır veya ayarlar.
/// </summary>
public int ItemCount { get; set; }
/// <summary>
/// ContainsChargeableItems değerini alır veya ayarlar.
/// </summary>
public bool ContainsChargeableItems { get; set; }
/// <summary>
/// ContainsIncludedItems değerini alır veya ayarlar.
/// </summary>
public bool ContainsIncludedItems { get; set; }
/// <summary>
/// MinimumPrice değerini alır veya ayarlar.
/// </summary>
public decimal? MinimumPrice { get; set; }
/// <summary>
/// CurrencyCode değerini alır veya ayarlar.
/// </summary>
public string CurrencyCode { get; set; } = "TRY";
/// <summary>
/// PreviewImageUrl değerini alır veya ayarlar.
/// </summary>
public string? PreviewImageUrl { get; set; }
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
    }
}
