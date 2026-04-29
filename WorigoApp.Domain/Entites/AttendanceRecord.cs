using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Personelin gunluk vardiya, yoklama ve giris-cikis kayitlarini tutar.
    /// </summary>
    public class AttendanceRecord : EntityBase
    {
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        public int? ShiftId { get; set; }
        public Shift? Shift { get; set; }
        public DateTime WorkDate { get; set; }
        public TimeSpan? PlannedStartTime { get; set; }
        public TimeSpan? PlannedEndTime { get; set; }
        public DateTime? CheckInAt { get; set; }
        public DateTime? CheckOutAt { get; set; }
        public AttendanceStatusEnum Status { get; set; } = AttendanceStatusEnum.Present;
        public int LateMinutes { get; set; }
        public int OvertimeMinutes { get; set; }
        public string? Note { get; set; }
    }
}
