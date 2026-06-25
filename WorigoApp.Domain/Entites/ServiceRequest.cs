using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Misafirin oluşturduğu ve personele atanan ana servis talebini tutar.
    /// </summary>
    public class ServiceRequest : EntityBase
    {
        /// <summary>
        /// Talebin ait olduğu otel.
        /// </summary>
        public int HotelId { get; set; }

/// <summary>
/// Hotel değerini alır veya ayarlar.
/// </summary>
public Hotel Hotel { get; set; } = null!;

        /// <summary>
        /// Talebin bağlı olduğu konaklama işlemi.
        /// </summary>
        public int GuestStayId { get; set; }

/// <summary>
/// GuestStay değerini alır veya ayarlar.
/// </summary>
public GuestStay GuestStay { get; set; } = null!;

        /// <summary>
        /// Talebin geldiği oda.
        /// </summary>
        public int? RoomId { get; set; }

/// <summary>
/// Room değerini alır veya ayarlar.
/// </summary>
public Room? Room { get; set; }

        /// <summary>
        /// Talebi açan misafir.
        /// </summary>
        public int? CustomerId { get; set; }

/// <summary>
/// Customer değerini alır veya ayarlar.
/// </summary>
public Customer? Customer { get; set; }

        /// <summary>
        /// Servis türü.
        /// </summary>
        public ServicesEnum ServiceType { get; set; }

        /// <summary>
        /// İlgili katalog kaydının ID bilgisi.
        /// </summary>
        public int? ServiceCatalogItemId { get; set; }

/// <summary>
/// ServiceDefinitionId değerini alır veya ayarlar.
/// </summary>
public int? ServiceDefinitionId { get; set; }

/// <summary>
/// ServiceDefinition değerini alır veya ayarlar.
/// </summary>
public ServiceDefinition? ServiceDefinition { get; set; }

        /// <summary>
        /// Talebin kısa başlığı.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Talebin detay açıklaması.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Talebin mevcut durumu.
        /// </summary>
        public ServiceRequestStatusEnum Status { get; set; } = ServiceRequestStatusEnum.Open;

        /// <summary>
        /// Talebin öncelik seviyesi.
        /// </summary>
        public ServiceRequestPriorityEnum Priority { get; set; } = ServiceRequestPriorityEnum.Normal;

        /// <summary>
        /// Talebin hangi kanaldan açıldığı.
        /// </summary>
        public ServiceRequestSourceEnum RequestSource { get; set; } = ServiceRequestSourceEnum.Mobile;

        /// <summary>
        /// Talebin ait olduğu departman.
        /// </summary>
        public int? DepartmentId { get; set; }

/// <summary>
/// Department değerini alır veya ayarlar.
/// </summary>
public Department? Department { get; set; }

        /// <summary>
        /// Talep hangi personele atandıysa onun bilgisi.
        /// </summary>
        public int? AssignedEmployeeId { get; set; }

/// <summary>
/// AssignedEmployee değerini alır veya ayarlar.
/// </summary>
public Employee? AssignedEmployee { get; set; }

        /// <summary>
        /// Talebin açıldığı dil.
        /// </summary>
        public string LanguageCode { get; set; } = "tr-TR";

        /// <summary>
        /// Talep oluşturulma zamanı.
        /// </summary>
        public DateTime RequestedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Talep personele atandığı an.
        /// </summary>
        public DateTime? AssignedAt { get; set; }

        /// <summary>
        /// İşleme başlama zamanı.
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// İşin tamamlandığı an.
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Talebin kapandığı an.
        /// </summary>
        public DateTime? ClosedAt { get; set; }

        /// <summary>
        /// SLA veya hedef teslim zamanı.
        /// </summary>
        public DateTime? DueAt { get; set; }

        /// <summary>
        /// Çözüm notu veya personel açıklaması.
        /// </summary>
        public string? ResolutionNote { get; set; }

        /// <summary>
        /// Talep için chat başlatıldı mı?
        /// </summary>
        public bool IsChatStarted { get; set; }

        /// <summary>
        /// Talep bir sohbetten doğduysa ilgili sohbet oturumunun ID bilgisidir.
        /// </summary>
        public int? ConversationId { get; set; }

/// <summary>
/// Conversation değerini alır veya ayarlar.
/// </summary>
public Conversation? Conversation { get; set; }

/// <summary>
/// Histories değerini alır veya ayarlar.
/// </summary>
public IList<ServiceRequestHistory> Histories { get; set; } = new List<ServiceRequestHistory>();
/// <summary>
/// Ratings değerini alır veya ayarlar.
/// </summary>
public IList<ServiceRequestRating> Ratings { get; set; } = new List<ServiceRequestRating>();
/// <summary>
/// StockRequests değerini alır veya ayarlar.
/// </summary>
public IList<StockRequest> StockRequests { get; set; } = new List<StockRequest>();
/// <summary>
/// FieldValues değerini alır veya ayarlar.
/// </summary>
public IList<ServiceRequestFieldValue> FieldValues { get; set; } = new List<ServiceRequestFieldValue>();
/// <summary>
/// Items değerini alır veya ayarlar.
/// </summary>
public IList<ServiceRequestItem> Items { get; set; } = new List<ServiceRequestItem>();
/// <summary>
/// Charges değerini alır veya ayarlar.
/// </summary>
public IList<Charge> Charges { get; set; } = new List<Charge>();
/// <summary>
/// Orders değerini alır veya ayarlar.
/// </summary>
public IList<Order> Orders { get; set; } = new List<Order>();
    }
}
