using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class GuestNotification : EntityBase
    {
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;
        public int GuestStayId { get; set; }
        public GuestStay GuestStay { get; set; } = null!;
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public int GuestSessionId { get; set; }
        public GuestSession GuestSession { get; set; } = null!;
        public string Title { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string NotificationType { get; set; } = string.Empty; // Welcome, Recommendation, Info, Warning
        public string? RelatedEntityType { get; set; }
        public int? RelatedEntityId { get; set; }
        public bool IsRead { get; set; } = false;
        public DateTime? ReadAt { get; set; }
        public DateTime ScheduledAt { get; set; }
        public DateTime? SentAt { get; set; }
    }
}
