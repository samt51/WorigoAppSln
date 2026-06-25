using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// UserNotification sınıfını temsil eder.
/// </summary>
public class UserNotification : EntityBase
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
/// UserId değerini alır veya ayarlar.
/// </summary>
public int? UserId { get; set; }
/// <summary>
/// User değerini alır veya ayarlar.
/// </summary>
public Users? User { get; set; }

/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int? EmployeeId { get; set; }
/// <summary>
/// Employee değerini alır veya ayarlar.
/// </summary>
public Employee? Employee { get; set; }

/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int? DepartmentId { get; set; }
/// <summary>
/// Department değerini alır veya ayarlar.
/// </summary>
public Department? Department { get; set; }

/// <summary>
/// ServiceRequestId değerini alır veya ayarlar.
/// </summary>
public int? ServiceRequestId { get; set; }
/// <summary>
/// ServiceRequest değerini alır veya ayarlar.
/// </summary>
public ServiceRequest? ServiceRequest { get; set; }

/// <summary>
/// Title değerini alır veya ayarlar.
/// </summary>
public string Title { get; set; } = string.Empty;
/// <summary>
/// Message değerini alır veya ayarlar.
/// </summary>
public string Message { get; set; } = string.Empty;
/// <summary>
/// NotificationType değerini alır veya ayarlar.
/// </summary>
public string NotificationType { get; set; } = string.Empty;
/// <summary>
/// IsRead değerini alır veya ayarlar.
/// </summary>
public bool IsRead { get; set; }
/// <summary>
/// ReadAt değerini alır veya ayarlar.
/// </summary>
public DateTime? ReadAt { get; set; }
    }
}
