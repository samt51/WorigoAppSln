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
        public int ServiceRequestId { get; set; }

        public ServiceRequest ServiceRequest { get; set; } = null!;

        /// <summary>
        /// Puanlamayı yapan misafir.
        /// </summary>
        public int? CustomerId { get; set; }

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
        /// Puanlama zamanı.
        /// </summary>
        public DateTime RatedAt { get; set; } = DateTime.UtcNow;
    }
}
