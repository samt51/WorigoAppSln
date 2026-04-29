using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Attendance.Commands.UpsertAttendanceRecord
{
    public class UpsertAttendanceRecordCommandResponse
    {
        public int Id { get; set; }
        public AttendanceStatusEnum Status { get; set; }
        public int LateMinutes { get; set; }
        public int OvertimeMinutes { get; set; }
    }
}
