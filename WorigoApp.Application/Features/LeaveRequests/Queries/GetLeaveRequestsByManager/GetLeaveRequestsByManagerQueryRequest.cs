using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.LeaveRequests.Queries.GetLeaveRequestsByManager
{
/// <summary>
/// GetLeaveRequestsByManagerQueryRequest sınıfını temsil eder.
/// </summary>
public class GetLeaveRequestsByManagerQueryRequest : IRequest<ResponseDto<IList<GetLeaveRequestsByManagerQueryResponse>>>
    {
/// <summary>
/// ManagerEmployeeId değerini alır veya ayarlar.
/// </summary>
public int ManagerEmployeeId { get; set; }
/// <summary>
/// IsHrView değerini alır veya ayarlar.
/// </summary>
public bool IsHrView { get; set; }
    }
}
