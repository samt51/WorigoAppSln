using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Hr.Attendance.Queries.GetAttendanceByEmployee
{
    public class GetAttendanceByEmployeeQueryRequest : IRequest<ResponseDto<IList<GetAttendanceByEmployeeQueryResponse>>>
    {
        public int EmployeeId { get; set; }
    }
}
