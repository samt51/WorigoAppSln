using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Personelin gunluk vardiya, yoklama ve giris-cikis kayitlarini tutar.
    /// </summary>
    public class AttendanceRecord : EntityBase
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// Hotel değerini alır veya ayarlar.
/// </summary>
public Hotel Hotel { get; set; } = null!;
/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int EmployeeId { get; set; }
/// <summary>
/// Employee değerini alır veya ayarlar.
/// </summary>
public Employee Employee { get; set; } = null!;
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int? DepartmentId { get; set; }
/// <summary>
/// Department değerini alır veya ayarlar.
/// </summary>
public Department? Department { get; set; }
/// <summary>
/// ShiftId değerini alır veya ayarlar.
/// </summary>
public int? ShiftId { get; set; }
/// <summary>
/// Shift değerini alır veya ayarlar.
/// </summary>
public Shift? Shift { get; set; }
/// <summary>
/// WorkDate değerini alır veya ayarlar.
/// </summary>
public DateTime WorkDate { get; set; }
/// <summary>
/// PlannedStartTime değerini alır veya ayarlar.
/// </summary>
public TimeSpan? PlannedStartTime { get; set; }
/// <summary>
/// PlannedEndTime değerini alır veya ayarlar.
/// </summary>
public TimeSpan? PlannedEndTime { get; set; }
/// <summary>
/// CheckInAt değerini alır veya ayarlar.
/// </summary>
public DateTime? CheckInAt { get; set; }
/// <summary>
/// CheckOutAt değerini alır veya ayarlar.
/// </summary>
public DateTime? CheckOutAt { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public AttendanceStatusEnum Status { get; set; } = AttendanceStatusEnum.Present;
/// <summary>
/// LateMinutes değerini alır veya ayarlar.
/// </summary>
public int LateMinutes { get; set; }
/// <summary>
/// OvertimeMinutes değerini alır veya ayarlar.
/// </summary>
public int OvertimeMinutes { get; set; }
/// <summary>
/// Note değerini alır veya ayarlar.
/// </summary>
public string? Note { get; set; }
    }
}
