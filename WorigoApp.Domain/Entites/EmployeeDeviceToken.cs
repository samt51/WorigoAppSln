using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// EmployeeDeviceToken sınıfını temsil eder.
/// </summary>
public class EmployeeDeviceToken : EntityBase
    {
/// <summary>
/// UserId değerini alır veya ayarlar.
/// </summary>
public int UserId { get; set; }
/// <summary>
/// User değerini alır veya ayarlar.
/// </summary>
public Users User { get; set; } = null!;

/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int EmployeeId { get; set; }
/// <summary>
/// Employee değerini alır veya ayarlar.
/// </summary>
public Employee Employee { get; set; } = null!;

/// <summary>
/// Token değerini alır veya ayarlar.
/// </summary>
public string Token { get; set; } = string.Empty;
/// <summary>
/// Platform değerini alır veya ayarlar.
/// </summary>
public string Platform { get; set; } = "unknown";
/// <summary>
/// DeviceId değerini alır veya ayarlar.
/// </summary>
public string? DeviceId { get; set; }
/// <summary>
/// LastSeenAt değerini alır veya ayarlar.
/// </summary>
public DateTime LastSeenAt { get; set; } = DateTime.UtcNow;
    }
}
