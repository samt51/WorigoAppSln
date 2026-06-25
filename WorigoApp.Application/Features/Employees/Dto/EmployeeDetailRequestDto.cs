namespace WorigoApp.Application.Features.Employees.Dto
{
/// <summary>
/// EmployeeDetailRequestDto sınıfını temsil eder.
/// </summary>
public class EmployeeDetailRequestDto
    {
/// <summary>
/// DateOfBirth değerini alır veya ayarlar.
/// </summary>
public DateTime DateOfBirth { get; set; }
/// <summary>
/// FloorNo değerini alır veya ayarlar.
/// </summary>
public int? FloorNo { get; set; }
/// <summary>
/// PhoneNumber değerini alır veya ayarlar.
/// </summary>
public string PhoneNumber { get; set; }
/// <summary>
/// Gender değerini alır veya ayarlar.
/// </summary>
public bool Gender { get; set; }
/// <summary>
/// StartDateOfWork değerini alır veya ayarlar.
/// </summary>
public DateTime StartDateOfWork { get; set; }
/// <summary>
/// ExitDateOfWork değerini alır veya ayarlar.
/// </summary>
public DateTime? ExitDateOfWork { get; set; }
/// <summary>
/// LastOnlineTime değerini alır veya ayarlar.
/// </summary>
public DateTime? LastOnlineTime { get; set; }
/// <summary>
/// OnlineOrOfflineNow değerini alır veya ayarlar.
/// </summary>
public bool OnlineOrOfflineNow { get; set; }
    }
}
