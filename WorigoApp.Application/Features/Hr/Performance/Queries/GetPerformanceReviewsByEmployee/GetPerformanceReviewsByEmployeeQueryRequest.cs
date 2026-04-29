using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Hr.Performance.Queries.GetPerformanceReviewsByEmployee
{
    public class GetPerformanceReviewsByEmployeeQueryRequest : IRequest<ResponseDto<IList<GetPerformanceReviewsByEmployeeQueryResponse>>>
    {
        public int EmployeeId { get; set; }
    }
}
