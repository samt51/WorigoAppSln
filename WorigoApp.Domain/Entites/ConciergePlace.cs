using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class ConciergePlace : EntityBase
    {
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Category { get; set; } = string.Empty;
        public string? Address { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? PhoneNumber { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? ImageUrl { get; set; }
        public int DisplayOrder { get; set; }
    }
}
