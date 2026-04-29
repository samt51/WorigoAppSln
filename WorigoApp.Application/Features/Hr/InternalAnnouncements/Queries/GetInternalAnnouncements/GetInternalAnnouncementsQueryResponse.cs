using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.InternalAnnouncements.Queries.GetInternalAnnouncements
{
    public class GetInternalAnnouncementsQueryResponse
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public InternalAnnouncementAudienceEnum Audience { get; set; }
        public DateTime PublishAt { get; set; }
        public DateTime? ExpireAt { get; set; }
        public bool IsPinned { get; set; }
    }
}
