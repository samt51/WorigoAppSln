using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Attendance.Queries.GetAttendanceByEmployee
{
/// <summary>
/// GetAttendanceByEmployeeQueryResponse sınıfını temsil eder.
/// </summary>
public class GetAttendanceByEmployeeQueryResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// WorkDate değerini alır veya ayarlar.
/// </summary>
public DateTime WorkDate { get; set; }
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
public AttendanceStatusEnum Status { get; set; }
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
