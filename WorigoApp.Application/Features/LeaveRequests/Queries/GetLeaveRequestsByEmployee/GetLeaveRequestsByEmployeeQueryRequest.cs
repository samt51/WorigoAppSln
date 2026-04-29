using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.LeaveRequests.Queries.GetLeaveRequestsByEmployee
{
    public class GetLeaveRequestsByEmployeeQueryRequest : IRequest<ResponseDto<IList<GetLeaveRequestsByEmployeeQueryResponse>>>
    {
        public int EmployeeId { get; set; }
    }
}
