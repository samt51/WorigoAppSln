using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Hr.Performance.Queries.GetPerformanceReviewsByEmployee
{
/// <summary>
/// GetPerformanceReviewsByEmployeeQueryHandler sınıfını temsil eder.
/// </summary>
public class GetPerformanceReviewsByEmployeeQueryHandler : BaseHandler, IRequestHandler<GetPerformanceReviewsByEmployeeQueryRequest, ResponseDto<IList<GetPerformanceReviewsByEmployeeQueryResponse>>>
    {
/// <summary>
/// GetPerformanceReviewsByEmployeeQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetPerformanceReviewsByEmployeeQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<GetPerformanceReviewsByEmployeeQueryResponse>>> Handle(GetPerformanceReviewsByEmployeeQueryRequest request, CancellationToken cancellationToken)
        {
            var reviews = await unitOfWork.GetReadRepository<PerformanceReview>().GetAllAsync(
                x => x.EmployeeId == request.EmployeeId && !x.IsDeleted,
                orderBy: x => x.OrderByDescending(y => y.ReviewDate));

            var response = reviews.Select(x => new GetPerformanceReviewsByEmployeeQueryResponse
            {
                Id = x.Id,
                Score = x.Score,
                Strengths = x.Strengths,
                ImprovementAreas = x.ImprovementAreas,
                ManagerNote = x.ManagerNote,
                Status = x.Status,
                ReviewDate = x.ReviewDate
            }).ToList();

            return new ResponseDto<IList<GetPerformanceReviewsByEmployeeQueryResponse>>().Success(response);
        }
    }
}
