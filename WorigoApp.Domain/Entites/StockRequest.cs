using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Personel veya departman tarafindan satin alma yoneticisine iletilen stok talebini tutar.
    /// </summary>
    public class StockRequest : EntityBase
    {
        /// <summary>
        /// Talebin ait oldugu otel.
        /// </summary>
        public int HotelId { get; set; }

/// <summary>
/// Hotel değerini alır veya ayarlar.
/// </summary>
public Hotel Hotel { get; set; } = null!;

        /// <summary>
        /// Talebi acan personel.
        /// </summary>
        public int RequestedByEmployeeId { get; set; }

/// <summary>
/// RequestedByEmployee değerini alır veya ayarlar.
/// </summary>
public Employee RequestedByEmployee { get; set; } = null!;

        /// <summary>
        /// Talebin yonlendirildigi satin alma veya sorumlu yonetici personel.
        /// </summary>
        public int? AssignedManagerEmployeeId { get; set; }

/// <summary>
/// AssignedManagerEmployee değerini alır veya ayarlar.
/// </summary>
public Employee? AssignedManagerEmployee { get; set; }

        /// <summary>
        /// Talebin ait oldugu departman.
        /// </summary>
        public int? DepartmentId { get; set; }

/// <summary>
/// Department değerini alır veya ayarlar.
/// </summary>
public Department? Department { get; set; }

        /// <summary>
        /// Talep belirli bir servis kaydi icin acildiysa baglantisini tutar.
        /// </summary>
        public int? RelatedServiceRequestId { get; set; }

/// <summary>
/// RelatedServiceRequest değerini alır veya ayarlar.
/// </summary>
public ServiceRequest? RelatedServiceRequest { get; set; }

        /// <summary>
        /// Talep basligi.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Talep aciklamasi.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Oncelik seviyesi.
        /// </summary>
        public StockRequestPriorityEnum Priority { get; set; } = StockRequestPriorityEnum.Normal;

        /// <summary>
        /// Talebin mevcut durumu.
        /// </summary>
        public StockRequestStatusEnum Status { get; set; } = StockRequestStatusEnum.Pending;

        /// <summary>
        /// Talebin acildigi an.
        /// </summary>
        public DateTime RequestedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Talep onaylandigi an.
        /// </summary>
        public DateTime? ApprovedAt { get; set; }

        /// <summary>
        /// Talep karsilanip dagitildigi an.
        /// </summary>
        public DateTime? FulfilledAt { get; set; }

        /// <summary>
        /// Yonetici notu.
        /// </summary>
        public string? ManagerNote { get; set; }

/// <summary>
/// Items değerini alır veya ayarlar.
/// </summary>
public IList<StockRequestItem> Items { get; set; } = new List<StockRequestItem>();
    }
}
