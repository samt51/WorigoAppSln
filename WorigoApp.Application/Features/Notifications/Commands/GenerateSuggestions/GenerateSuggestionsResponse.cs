using WorigoApp.Application.Features.Notifications.Dtos;

namespace WorigoApp.Application.Features.Notifications.Commands.GenerateSuggestions
{
    public class GenerateSuggestionsResponse
    {
        public int GeneratedCount { get; set; }
        public IList<SuggestionNotificationDto> NotificationsToBroadcast { get; set; } = new List<SuggestionNotificationDto>();
    }
}
