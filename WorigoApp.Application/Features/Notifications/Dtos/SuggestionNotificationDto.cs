namespace WorigoApp.Application.Features.Notifications.Dtos
{
    public class SuggestionNotificationDto
    {
        public int GuestStayId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string NotificationType { get; set; } = string.Empty;
        public DateTime? SentAt { get; set; }
    }
}
