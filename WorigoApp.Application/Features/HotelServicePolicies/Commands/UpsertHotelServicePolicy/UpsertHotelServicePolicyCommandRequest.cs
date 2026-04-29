using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.HotelServicePolicies.Commands.UpsertHotelServicePolicy
{
    public class UpsertHotelServicePolicyCommandRequest : IRequest<ResponseDto<UpsertHotelServicePolicyCommandResponse>>
    {
        public int HotelId { get; set; }
        public ServicesEnum ServiceType { get; set; }
        public int? ServiceItemId { get; set; }
        public AccommodationConceptTypeEnum AccommodationConceptType { get; set; }
        public bool IsVisible { get; set; } = true;
        public bool IsIncludedInPackage { get; set; }
        public bool IsChargeable { get; set; }
        public bool AllowRoomCharge { get; set; } = true;
        public bool AllowOnlinePayment { get; set; }
        public bool AllowOnSitePayment { get; set; } = true;
        public decimal? PriceOverride { get; set; }
        public string CurrencyCode { get; set; } = "TRY";
        public string? Description { get; set; }
    }
}
