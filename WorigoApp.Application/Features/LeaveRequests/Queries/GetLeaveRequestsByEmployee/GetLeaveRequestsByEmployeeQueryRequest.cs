using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.LeaveRequests.Queries.GetLeaveRequestsByEmployee
{
/// <summary>
/// GetLeaveRequestsByEmployeeQueryRequest sınıfını temsil eder.
/// </summary>
public class GetLeaveRequestsByEmployeeQueryRequest : IRequest<ResponseDto<IList<GetLeaveRequestsByEmployeeQueryResponse>>>
    {
/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int EmployeeId { get; set; }
    }
}
