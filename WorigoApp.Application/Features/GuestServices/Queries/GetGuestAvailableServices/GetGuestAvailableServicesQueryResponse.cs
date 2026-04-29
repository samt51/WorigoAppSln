using WorigoApp.Application.Features.GuestServices.Dtos;

namespace WorigoApp.Application.Features.GuestServices.Queries.GetGuestAvailableServices
{
    public class GetGuestAvailableServicesQueryResponse
    {
        public int? ServiceDefinitionId { get; set; }
        public int? ServiceCategoryId { get; set; }
        public string? ServiceCategoryName { get; set; }
        public string ServiceType { get; set; } = string.Empty;
        public int ServiceItemId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsChargeable { get; set; }
        public bool IsIncludedInPackage { get; set; }
        public decimal Price { get; set; }
        public string CurrencyCode { get; set; } = "TRY";
        public bool AllowRoomCharge { get; set; }
        public bool AllowOnlinePayment { get; set; }
        public bool AllowOnSitePayment { get; set; }
        public bool SupportsFreeText { get; set; }
        public bool RequiresAppointment { get; set; }
        public int? EstimatedDurationMinutes { get; set; }
        public int DisplayOrder { get; set; }
        public IList<ServiceDefinitionFieldDto> Fields { get; set; } = new List<ServiceDefinitionFieldDto>();
    }
}
