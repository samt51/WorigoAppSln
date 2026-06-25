using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Otelde misafire gösterilecek duyuru, etkinlik ve kampanya kayıtlarını tutar.
    /// </summary>
    public class Announcement : EntityBase
    {
        /// <summary>
        /// Başlık bilgisi.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Duyuru veya etkinlik açıklaması.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Görsel adresi.
        /// </summary>
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Duyurunun ait olduğu otel.
        /// </summary>
        public int HotelId { get; set; }

/// <summary>
/// Hotel değerini alır veya ayarlar.
/// </summary>
public Hotel Hotel { get; set; } = null!;

        /// <summary>
        /// Duyuru türü.
        /// </summary>
        public AnnouncementTypeEnum Type { get; set; } = AnnouncementTypeEnum.Announcement;

        /// <summary>
        /// Başlangıç zamanı.
        /// </summary>
        public DateTime StartAt { get; set; }

        /// <summary>
        /// Bitiş zamanı.
        /// </summary>
        public DateTime? EndAt { get; set; }

        /// <summary>
        /// Etkinlik veya duyurunun yapılacağı alan.
        /// </summary>
        public string? Location { get; set; }

        /// <summary>
        /// Duyuru sabitlenmiş olarak üstte gösterilsin mi?
        /// </summary>
        public bool IsPinned { get; set; }

        /// <summary>
        /// Misafire görünürlük durumu.
        /// </summary>
        public bool IsVisibleToGuest { get; set; } = true;

        /// <summary>
        /// Hedef kitle bilgisi. Örn: Tüm misafirler, VIP, çocuklu aileler.
        /// </summary>
        public string? AudienceType { get; set; }

/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int? DepartmentId { get; set; }
/// <summary>
/// Department değerini alır veya ayarlar.
/// </summary>
public Department? Department { get; set; }
/// <summary>
/// CreatedByEmployeeId değerini alır veya ayarlar.
/// </summary>
public int? CreatedByEmployeeId { get; set; }
/// <summary>
/// CreatedByEmployee değerini alır veya ayarlar.
/// </summary>
public Employee? CreatedByEmployee { get; set; }
/// <summary>
/// InternalAudience değerini alır veya ayarlar.
/// </summary>
public InternalAnnouncementAudienceEnum? InternalAudience { get; set; }
    }
}
