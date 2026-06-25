using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Hr.Tasks.Queries.GetEmployeeTasks
{
/// <summary>
/// GetEmployeeTasksQueryRequest sınıfını temsil eder.
/// </summary>
public class GetEmployeeTasksQueryRequest : IRequest<ResponseDto<IList<GetEmployeeTasksQueryResponse>>>
    {
/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int? EmployeeId { get; set; }
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int? DepartmentId { get; set; }
    }
}
