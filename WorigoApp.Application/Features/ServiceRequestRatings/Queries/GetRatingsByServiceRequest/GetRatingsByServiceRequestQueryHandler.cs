using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ServiceRequestRatings.Queries.GetRatingsByServiceRequest
{
    public class GetRatingsByServiceRequestQueryHandler : BaseHandler, IRequestHandler<GetRatingsByServiceRequestQueryRequest, ResponseDto<IList<GetRatingsByServiceRequestQueryResponse>>>
    {
        public GetRatingsByServiceRequestQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetRatingsByServiceRequestQueryResponse>>> Handle(GetRatingsByServiceRequestQueryRequest request, CancellationToken cancellationToken)
        {
            var ratings = await unitOfWork.GetReadRepository<ServiceRequestRating>().GetAllAsync(
                x => x.ServiceRequestId == request.ServiceRequestId && !x.IsDeleted,
                orderBy: x => x.OrderByDescending(y => y.RatedAt));

            var response = ratings.Select(x => new GetRatingsByServiceRequestQueryResponse
            {
                Id = x.Id,
                CustomerId = x.CustomerId,
                SpeedScore = x.SpeedScore,
                QualityScore = x.QualityScore,
                StaffScore = x.StaffScore,
                Comment = x.Comment,
                RatedAt = x.RatedAt
            }).ToList();

            return new ResponseDto<IList<GetRatingsByServiceRequestQueryResponse>>().Success(response);
        }
    }
}
