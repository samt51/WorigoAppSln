using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.HotelServicePolicies.Queries.GetHotelServicePolicies
{
/// <summary>
/// GetHotelServicePoliciesQueryRequest sınıfını temsil eder.
/// </summary>
public class GetHotelServicePoliciesQueryRequest : IRequest<ResponseDto<IList<GetHotelServicePoliciesQueryResponse>>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// AccommodationConceptType değerini alır veya ayarlar.
/// </summary>
public AccommodationConceptTypeEnum? AccommodationConceptType { get; set; }
    }
}
