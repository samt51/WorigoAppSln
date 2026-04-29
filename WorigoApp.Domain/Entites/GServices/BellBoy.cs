using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.GServices
{
    /// <summary>
    /// Misafirin bellboy hizmetleri için kullanacağı servis katalog kaydıdır.
    /// </summary>
    public class BellBoy : EntityBase
    {
        public BellBoy()
        {
        }

        /// <summary>
        /// Hizmet adı.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Görsel adresi.
        /// </summary>
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Hizmet açıklaması.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Bağlı otel.
        /// </summary>
        public int? HotelId { get; set; }

        /// <summary>
        /// İlgili departman.
        /// </summary>
        public int? DepartmentId { get; set; }

        /// <summary>
        /// Tahmini hizmet süresi.
        /// </summary>
        public int? EstimatedDurationMinutes { get; set; }

        /// <summary>
        /// Misafire görünürlük durumu.
        /// </summary>
        public bool IsVisibleToGuest { get; set; } = true;

        public BellBoy(int id, string name, string imageUrl)
        {
            Name = name;
            Id = id;
            ImageUrl = imageUrl;
        }
    }
}
