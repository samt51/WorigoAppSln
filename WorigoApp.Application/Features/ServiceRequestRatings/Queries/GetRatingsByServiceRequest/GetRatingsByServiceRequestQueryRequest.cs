using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ServiceRequestRatings.Queries.GetRatingsByServiceRequest
{
/// <summary>
/// GetRatingsByServiceRequestQueryRequest sınıfını temsil eder.
/// </summary>
public class GetRatingsByServiceRequestQueryRequest : IRequest<ResponseDto<IList<GetRatingsByServiceRequestQueryResponse>>>
    {
/// <summary>
/// ServiceRequestId değerini alır veya ayarlar.
/// </summary>
public int ServiceRequestId { get; set; }
    }
}
