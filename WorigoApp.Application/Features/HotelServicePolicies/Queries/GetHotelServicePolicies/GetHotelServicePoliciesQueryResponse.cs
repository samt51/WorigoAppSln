namespace WorigoApp.Application.Features.HotelServicePolicies.Queries.GetHotelServicePolicies
{
    public class GetHotelServicePoliciesQueryResponse
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string ServiceType { get; set; } = string.Empty;
        public int? ServiceItemId { get; set; }
        public string AccommodationConceptType { get; set; } = string.Empty;
        public bool IsVisible { get; set; }
        public bool IsIncludedInPackage { get; set; }
        public bool IsChargeable { get; set; }
        public bool AllowRoomCharge { get; set; }
        public bool AllowOnlinePayment { get; set; }
        public bool AllowOnSitePayment { get; set; }
        public decimal? PriceOverride { get; set; }
        public string CurrencyCode { get; set; } = "TRY";
        public string? Description { get; set; }
    }
}
