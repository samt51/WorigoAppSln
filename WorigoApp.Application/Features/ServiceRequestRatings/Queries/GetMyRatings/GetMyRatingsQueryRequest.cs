using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ServiceRequestRatings.Queries.GetMyRatings
{
    public class GetMyRatingsQueryRequest : IRequest<ResponseDto<IList<ServiceRequestRating>>>
    {
        public string SessionToken { get; set; } = string.Empty;
    }
}
