using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Attendance.Commands.UpsertAttendanceRecord
{
/// <summary>
/// UpsertAttendanceRecordCommandRequest sınıfını temsil eder.
/// </summary>
public class UpsertAttendanceRecordCommandRequest : IRequest<ResponseDto<UpsertAttendanceRecordCommandResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int EmployeeId { get; set; }
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
public AttendanceStatusEnum? Status { get; set; }
/// <summary>
/// Note değerini alır veya ayarlar.
/// </summary>
public string? Note { get; set; }
    }
}
