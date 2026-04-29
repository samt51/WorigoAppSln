using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.GServices
{
    /// <summary>
    /// Misafirin kat hizmetleri taleplerinde kullanacağı servis katalog kaydıdır.
    /// </summary>
    public class HouseKeeping : EntityBase
    {
        public HouseKeeping()
        {
        }

        /// <summary>
        /// Kat hizmeti adı.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Kat hizmeti açıklaması.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Görsel adresi.
        /// </summary>
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Kaydın bağlı olduğu otel.
        /// </summary>
        public int? HotelId { get; set; }

        /// <summary>
        /// İlgili departman.
        /// </summary>
        public int? DepartmentId { get; set; }

        /// <summary>
        /// Üst kategori bilgisi.
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// Misafir tarafında görüntüleme sırası.
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Misafire açık mı?
        /// </summary>
        public bool IsVisibleToGuest { get; set; } = true;

        /// <summary>
        /// Serbest açıklama alanı açılsın mı?
        /// </summary>
        public bool SupportsFreeText { get; set; } = true;

        /// <summary>
        /// Tahmini servis süresi.
        /// </summary>
        public int? EstimatedDurationMinutes { get; set; }

        public HouseKeeping(int id, string name, string imageUrl)
        {
            Id = id;
            Name = name;
            ImageUrl = imageUrl;
        }
    }
}
