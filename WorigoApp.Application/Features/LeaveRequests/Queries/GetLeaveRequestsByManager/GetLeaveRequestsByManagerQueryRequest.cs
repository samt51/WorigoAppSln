using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.LeaveRequests.Queries.GetLeaveRequestsByManager
{
    public class GetLeaveRequestsByManagerQueryRequest : IRequest<ResponseDto<IList<GetLeaveRequestsByManagerQueryResponse>>>
    {
        public int ManagerEmployeeId { get; set; }
        public bool IsHrView { get; set; }
    }
}
