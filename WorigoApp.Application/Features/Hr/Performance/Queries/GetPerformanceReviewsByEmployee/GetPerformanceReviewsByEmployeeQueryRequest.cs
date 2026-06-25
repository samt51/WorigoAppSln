using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Hr.Performance.Queries.GetPerformanceReviewsByEmployee
{
/// <summary>
/// GetPerformanceReviewsByEmployeeQueryRequest sınıfını temsil eder.
/// </summary>
public class GetPerformanceReviewsByEmployeeQueryRequest : IRequest<ResponseDto<IList<GetPerformanceReviewsByEmployeeQueryResponse>>>
    {
/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int EmployeeId { get; set; }
    }
}
