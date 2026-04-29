using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ServiceRequestRatings.Queries.GetRatingsByServiceRequest
{
    public class GetRatingsByServiceRequestQueryRequest : IRequest<ResponseDto<IList<GetRatingsByServiceRequestQueryResponse>>>
    {
        public int ServiceRequestId { get; set; }
    }
}
