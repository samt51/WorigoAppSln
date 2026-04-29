using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites.GServices
{
    /// <summary>
    /// Otel bilgi kartları, etkinlikler ve duyurular için kullanılan eski katalog yapısıdır.
    /// </summary>
    public class HotelInformationAndAnnouncements : EntityBase
    {
        public HotelInformationAndAnnouncements()
        {
        }

        public string Name { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public int? HotelId { get; set; }
        public AnnouncementTypeEnum AnnouncementType { get; set; } = AnnouncementTypeEnum.Announcement;
        public DateTime? EndDate { get; set; }
        public string? Location { get; set; }
        public bool IsPinned { get; set; }
        public bool IsVisibleToGuest { get; set; } = true;

        public HotelInformationAndAnnouncements(int id, string name, string imageUrl, string description, DateTime date)
        {
            Id = id;
            Name = name;
            ImageUrl = imageUrl;
            Description = description;
            Date = date;
        }
    }
}
