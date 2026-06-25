using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Servis talebindeki durum değişikliklerini ve denetim izini tutar.
    /// </summary>
    public class ServiceRequestHistory : EntityBase
    {
        /// <summary>
        /// Geçmiş kaydının ait olduğu servis talebi.
        /// </summary>
        public int ServiceRequestId { get; set; }

/// <summary>
/// ServiceRequest değerini alır veya ayarlar.
/// </summary>
public ServiceRequest ServiceRequest { get; set; } = null!;

        /// <summary>
        /// Önceki durum.
        /// </summary>
        public ServiceRequestStatusEnum? OldStatus { get; set; }

        /// <summary>
        /// Yeni durum.
        /// </summary>
        public ServiceRequestStatusEnum NewStatus { get; set; }

        /// <summary>
        /// Değişikliği yapan kullanıcı.
        /// </summary>
        public int? ChangedByUserId { get; set; }

/// <summary>
/// ChangedByUser değerini alır veya ayarlar.
/// </summary>
public Users? ChangedByUser { get; set; }

        /// <summary>
        /// Değişikliğin yapıldığı zaman.
        /// </summary>
        public DateTime ChangedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Ek not.
        /// </summary>
        public string? Note { get; set; }
    }
}
