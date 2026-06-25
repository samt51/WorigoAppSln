namespace WorigoApp.Application.Features.Notifications.Dtos
{
/// <summary>
/// SuggestionNotificationDto sınıfını temsil eder.
/// </summary>
public class SuggestionNotificationDto
    {
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
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
/// SentAt değerini alır veya ayarlar.
/// </summary>
public DateTime? SentAt { get; set; }
    }
}
