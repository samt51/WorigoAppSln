using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// GuestNotification sınıfını temsil eder.
/// </summary>
public class GuestNotification : EntityBase
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
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
/// <summary>
/// GuestStay değerini alır veya ayarlar.
/// </summary>
public GuestStay GuestStay { get; set; } = null!;
/// <summary>
/// CustomerId değerini alır veya ayarlar.
/// </summary>
public int CustomerId { get; set; }
/// <summary>
/// Customer değerini alır veya ayarlar.
/// </summary>
public Customer Customer { get; set; } = null!;
/// <summary>
/// GuestSessionId değerini alır veya ayarlar.
/// </summary>
public int GuestSessionId { get; set; }
/// <summary>
/// GuestSession değerini alır veya ayarlar.
/// </summary>
public GuestSession GuestSession { get; set; } = null!;
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
public string NotificationType { get; set; } = string.Empty; // Welcome, Recommendation, Info, Warning
/// <summary>
/// RelatedEntityType değerini alır veya ayarlar.
/// </summary>
public string? RelatedEntityType { get; set; }
/// <summary>
/// RelatedEntityId değerini alır veya ayarlar.
/// </summary>
public int? RelatedEntityId { get; set; }
/// <summary>
/// IsRead değerini alır veya ayarlar.
/// </summary>
public bool IsRead { get; set; } = false;
/// <summary>
/// ReadAt değerini alır veya ayarlar.
/// </summary>
public DateTime? ReadAt { get; set; }
/// <summary>
/// ScheduledAt değerini alır veya ayarlar.
/// </summary>
public DateTime ScheduledAt { get; set; }
/// <summary>
/// SentAt değerini alır veya ayarlar.
/// </summary>
public DateTime? SentAt { get; set; }
    }
}
