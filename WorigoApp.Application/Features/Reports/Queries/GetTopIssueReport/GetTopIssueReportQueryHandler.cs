using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Reports.Queries.GetTopIssueReport
{
    public class GetTopIssueReportQueryHandler : BaseHandler, IRequestHandler<GetTopIssueReportQueryRequest, ResponseDto<IList<GetTopIssueReportQueryResponse>>>
    {
        public GetTopIssueReportQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetTopIssueReportQueryResponse>>> Handle(GetTopIssueReportQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceRequests = await unitOfWork.GetReadRepository<Domain.Entites.ServiceRequest>().GetAllAsync(
                x => x.HotelId == request.HotelId && !x.IsDeleted);

            var grouped = serviceRequests
                .GroupBy(x => new { x.ServiceType, x.ServiceCatalogItemId, x.Title })
                .Select(group => new GetTopIssueReportQueryResponse
                {
                    ServiceType = group.Key.ServiceType,
                    ServiceCatalogItemId = group.Key.ServiceCatalogItemId,
                    Title = group.Key.Title,
                    TotalCount = group.Count(),
                    OpenCount = group.Count(x => x.Status != ServiceRequestStatusEnum.Completed && x.Status != ServiceRequestStatusEnum.Closed),
                    AverageResolutionMinutes = group
                        .Where(x => x.AssignedAt.HasValue && x.CompletedAt.HasValue)
                        .Select(x => (decimal)(x.CompletedAt.Value - x.AssignedAt.Value).TotalMinutes)
                        .DefaultIfEmpty(0)
                        .Average()
                })
                .OrderByDescending(x => x.TotalCount)
                .Take(Math.Max(request.Take, 1))
                .ToList();

            return new ResponseDto<IList<GetTopIssueReportQueryResponse>>().Success(grouped);
        }
    }
}
