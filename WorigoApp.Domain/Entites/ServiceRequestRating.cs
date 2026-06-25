using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Tamamlanan servis talebi için misafirin verdiği puan ve yorumu tutar.
    /// </summary>
    public class ServiceRequestRating : EntityBase
    {
        /// <summary>
        /// Puanlanan servis talebi.
        /// </summary>
        public int? ServiceRequestId { get; set; }

/// <summary>
/// ServiceRequest değerini alır veya ayarlar.
/// </summary>
public ServiceRequest? ServiceRequest { get; set; }

        /// <summary>
        /// Puanlamayı yapan misafir.
        /// </summary>
        public int? CustomerId { get; set; }

/// <summary>
/// Customer değerini alır veya ayarlar.
/// </summary>
public Customer? Customer { get; set; }

        /// <summary>
        /// Hız puanı.
        /// </summary>
        public decimal SpeedScore { get; set; }

        /// <summary>
        /// Hizmet kalitesi puanı.
        /// </summary>
        public decimal QualityScore { get; set; }

        /// <summary>
        /// Personel davranış puanı.
        /// </summary>
        public decimal StaffScore { get; set; }

        /// <summary>
        /// Misafir yorumu.
        /// </summary>
        public string? Comment { get; set; }
/// <summary>
/// OverallScore değerini alır veya ayarlar.
/// </summary>
public decimal? OverallScore { get; set; }

        /// <summary>
        /// Puanlama zamanı.
        /// </summary>
        public DateTime RatedAt { get; set; } = DateTime.UtcNow;

/// <summary>
/// OrderId değerini alır veya ayarlar.
/// </summary>
public int? OrderId { get; set; }
/// <summary>
/// Order değerini alır veya ayarlar.
/// </summary>
public Order? Order { get; set; }
/// <summary>
/// OrderItemId değerini alır veya ayarlar.
/// </summary>
public int? OrderItemId { get; set; }
/// <summary>
/// OrderItem değerini alır veya ayarlar.
/// </summary>
public OrderItem? OrderItem { get; set; }
/// <summary>
/// FoodId değerini alır veya ayarlar.
/// </summary>
public int? FoodId { get; set; }
/// <summary>
/// Food değerini alır veya ayarlar.
/// </summary>
public Food? Food { get; set; }
    }
}
