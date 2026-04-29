using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.HotelServicePolicies.Queries.GetHotelServicePolicies
{
    public class GetHotelServicePoliciesQueryRequest : IRequest<ResponseDto<IList<GetHotelServicePoliciesQueryResponse>>>
    {
        public int HotelId { get; set; }
        public AccommodationConceptTypeEnum? AccommodationConceptType { get; set; }
    }
}
