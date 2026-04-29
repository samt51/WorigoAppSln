using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Personel, yonetici ve IK tarafina gosterilecek ic duyurulari tutar.
    /// </summary>
    public class InternalAnnouncement : EntityBase
    {
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        public int CreatedByEmployeeId { get; set; }
        public Employee CreatedByEmployee { get; set; } = null!;
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public InternalAnnouncementAudienceEnum Audience { get; set; } = InternalAnnouncementAudienceEnum.AllEmployees;
        public DateTime PublishAt { get; set; } = DateTime.UtcNow;
        public DateTime? ExpireAt { get; set; }
        public bool IsPinned { get; set; }
    }
}
