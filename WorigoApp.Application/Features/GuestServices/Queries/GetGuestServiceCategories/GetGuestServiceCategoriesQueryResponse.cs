using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.GuestServices.Queries.GetGuestServiceCategories
{
    public class GetGuestServiceCategoriesQueryResponse
    {
        public int? ServiceCategoryId { get; set; }
        public string ServiceType { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public int ItemCount { get; set; }
        public bool ContainsChargeableItems { get; set; }
        public bool ContainsIncludedItems { get; set; }
        public decimal? MinimumPrice { get; set; }
        public string CurrencyCode { get; set; } = "TRY";
        public string? PreviewImageUrl { get; set; }
        public ServiceFlowUiTypeEnum FlowUiType { get; set; }
        public ConversationMessageTypeEnum OpeningMessageType { get; set; }
        public string OpeningMessage { get; set; } = string.Empty;
        public string? OpeningPayloadJson { get; set; }
    }
}
