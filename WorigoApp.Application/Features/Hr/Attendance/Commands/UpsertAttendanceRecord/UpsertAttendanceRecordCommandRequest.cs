using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Attendance.Commands.UpsertAttendanceRecord
{
    public class UpsertAttendanceRecordCommandRequest : IRequest<ResponseDto<UpsertAttendanceRecordCommandResponse>>
    {
        public int HotelId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime WorkDate { get; set; }
        public DateTime? CheckInAt { get; set; }
        public DateTime? CheckOutAt { get; set; }
        public AttendanceStatusEnum? Status { get; set; }
        public string? Note { get; set; }
    }
}
