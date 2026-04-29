using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Attendance.Queries.GetAttendanceByEmployee
{
    public class GetAttendanceByEmployeeQueryResponse
    {
        public int Id { get; set; }
        public DateTime WorkDate { get; set; }
        public DateTime? CheckInAt { get; set; }
        public DateTime? CheckOutAt { get; set; }
        public AttendanceStatusEnum Status { get; set; }
        public int LateMinutes { get; set; }
        public int OvertimeMinutes { get; set; }
        public string? Note { get; set; }
    }
}
