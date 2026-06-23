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

        public Hotel Hotel { get; set; } = null!;

        /// <summary>
        /// Talebin bağlı olduğu konaklama işlemi.
        /// </summary>
        public int GuestStayId { get; set; }

        public GuestStay GuestStay { get; set; } = null!;

        /// <summary>
        /// Talebin geldiği oda.
        /// </summary>
        public int? RoomId { get; set; }

        public Room? Room { get; set; }

        /// <summary>
        /// Talebi açan misafir.
        /// </summary>
        public int? CustomerId { get; set; }

        public Customer? Customer { get; set; }

        /// <summary>
        /// Servis türü.
        /// </summary>
        public ServicesEnum ServiceType { get; set; }

        /// <summary>
        /// İlgili katalog kaydının ID bilgisi.
        /// </summary>
        public int? ServiceCatalogItemId { get; set; }

        public int? ServiceDefinitionId { get; set; }

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

        public Department? Department { get; set; }

        /// <summary>
        /// Talep hangi personele atandıysa onun bilgisi.
        /// </summary>
        public int? AssignedEmployeeId { get; set; }

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

        public Conversation? Conversation { get; set; }

        public IList<ServiceRequestHistory> Histories { get; set; } = new List<ServiceRequestHistory>();
        public IList<ServiceRequestRating> Ratings { get; set; } = new List<ServiceRequestRating>();
        public IList<StockRequest> StockRequests { get; set; } = new List<StockRequest>();
        public IList<ServiceRequestFieldValue> FieldValues { get; set; } = new List<ServiceRequestFieldValue>();
        public IList<ServiceRequestItem> Items { get; set; } = new List<ServiceRequestItem>();
        public IList<Charge> Charges { get; set; } = new List<Charge>();
        public IList<Order> Orders { get; set; } = new List<Order>();
    }
}
