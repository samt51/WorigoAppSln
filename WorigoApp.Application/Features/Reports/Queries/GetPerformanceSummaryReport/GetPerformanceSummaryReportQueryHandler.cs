using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;

namespace WorigoApp.Application.Features.Reports.Queries.GetPerformanceSummaryReport
{
/// <summary>
/// GetPerformanceSummaryReportQueryHandler sınıfını temsil eder.
/// </summary>
public class GetPerformanceSummaryReportQueryHandler : BaseHandler, IRequestHandler<GetPerformanceSummaryReportQueryRequest, ResponseDto<GetPerformanceSummaryReportQueryResponse>>
    {
/// <summary>
/// GetPerformanceSummaryReportQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetPerformanceSummaryReportQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<GetPerformanceSummaryReportQueryResponse>> Handle(GetPerformanceSummaryReportQueryRequest request, CancellationToken cancellationToken)
        {
            if (!await CheckHotelAccessAsync(request.HotelId))
            {
                return new ResponseDto<GetPerformanceSummaryReportQueryResponse>().Fail("Bu işlem için yetkiniz bulunmamaktadır.", 403);
            }

            var reviews = await unitOfWork.GetReadRepository<Domain.Entites.PerformanceReview>().GetAllAsync(x => x.HotelId == request.HotelId && !x.IsDeleted);

            return new ResponseDto<GetPerformanceSummaryReportQueryResponse>().Success(new GetPerformanceSummaryReportQueryResponse
            {
                TotalReviewCount = reviews.Count,
                AverageScore = reviews.Count == 0 ? 0 : reviews.Average(x => x.Score),
                LowScoreReviewCount = reviews.Count(x => x.Score < 3),
                HighScoreReviewCount = reviews.Count(x => x.Score >= 4)
            });
        }
    }
}
