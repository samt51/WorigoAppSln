using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.LeaveRequests.Commands.CreateLeaveRequest
{
    public class CreateLeaveRequestCommandRequest : IRequest<ResponseDto<CreateLeaveRequestCommandResponse>>
    {
        public int HotelId { get; set; }
        public int EmployeeId { get; set; }
        public int? HrEmployeeId { get; set; }
        public LeaveRequestTypeEnum LeaveType { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Reason { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
