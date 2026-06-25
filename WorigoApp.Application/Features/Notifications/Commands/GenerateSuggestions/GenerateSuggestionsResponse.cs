using WorigoApp.Application.Features.Notifications.Dtos;

namespace WorigoApp.Application.Features.Notifications.Commands.GenerateSuggestions
{
/// <summary>
/// GenerateSuggestionsResponse sınıfını temsil eder.
/// </summary>
public class GenerateSuggestionsResponse
    {
/// <summary>
/// GeneratedCount değerini alır veya ayarlar.
/// </summary>
public int GeneratedCount { get; set; }
/// <summary>
/// NotificationsToBroadcast değerini alır veya ayarlar.
/// </summary>
public IList<SuggestionNotificationDto> NotificationsToBroadcast { get; set; } = new List<SuggestionNotificationDto>();
    }
}
