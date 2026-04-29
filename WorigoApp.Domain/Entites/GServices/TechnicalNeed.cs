using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.GServices
{
    /// <summary>
    /// Misafirin teknik arıza veya bakım talebi açabileceği teknik servis katalog kaydıdır.
    /// </summary>
    public class TechnicalNeed : EntityBase
    {
        public TechnicalNeed()
        {
        }

        /// <summary>
        /// Teknik ihtiyaç başlığı.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Teknik ihtiyaç açıklaması.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Teknik ihtiyaç görseli.
        /// </summary>
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Kaydın bağlı olduğu otel.
        /// </summary>
        public int? HotelId { get; set; }

        /// <summary>
        /// İlgili teknik departman.
        /// </summary>
        public int? DepartmentId { get; set; }

        /// <summary>
        /// Alt kategori ilişkisi için üst kayıt ID bilgisi.
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// Misafire görünme sırası.
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Misafire gösterilsin mi?
        /// </summary>
        public bool IsVisibleToGuest { get; set; } = true;

        /// <summary>
        /// Serbest metin girilebilsin mi?
        /// </summary>
        public bool SupportsFreeText { get; set; } = true;

        /// <summary>
        /// Tahmini çözüm süresi dakikası.
        /// </summary>
        public int? EstimatedDurationMinutes { get; set; }

        /// <summary>
        /// Hedef servis seviyesi süresi dakikası.
        /// </summary>
        public int? SlaMinutes { get; set; }

        public TechnicalNeed(int id, string name, string description, string imageUrl)
        {
            Id = id;
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }
    }
}
