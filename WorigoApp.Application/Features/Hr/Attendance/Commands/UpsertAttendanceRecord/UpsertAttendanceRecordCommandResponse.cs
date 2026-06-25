using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Attendance.Commands.UpsertAttendanceRecord
{
/// <summary>
/// UpsertAttendanceRecordCommandResponse sınıfını temsil eder.
/// </summary>
public class UpsertAttendanceRecordCommandResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public AttendanceStatusEnum Status { get; set; }
/// <summary>
/// LateMinutes değerini alır veya ayarlar.
/// </summary>
public int LateMinutes { get; set; }
/// <summary>
/// OvertimeMinutes değerini alır veya ayarlar.
/// </summary>
public int OvertimeMinutes { get; set; }
    }
}
