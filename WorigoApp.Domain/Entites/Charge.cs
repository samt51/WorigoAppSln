using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Oda folyosuna yazılan veya online tahsil edilecek ücret kalemini temsil eder.
    /// </summary>
    public class Charge : EntityBase
    {
        /// <summary>
        /// Ücret kaleminin bağlı olduğu konaklama kaydıdır.
        /// </summary>
        public int GuestStayId { get; set; }

/// <summary>
/// GuestStay değerini alır veya ayarlar.
/// </summary>
public GuestStay GuestStay { get; set; } = null!;

        /// <summary>
        /// Ücret bir yemek veya ürün siparişinden doğduysa ilgili sipariş bilgisidir.
        /// </summary>
        public int? OrderId { get; set; }

/// <summary>
/// Order değerini alır veya ayarlar.
/// </summary>
public Order? Order { get; set; }

        /// <summary>
        /// Ücret bir servis talebinden doğduysa ilgili talep bilgisidir.
        /// </summary>
        public int? ServiceRequestId { get; set; }

/// <summary>
/// ServiceRequest değerini alır veya ayarlar.
/// </summary>
public ServiceRequest? ServiceRequest { get; set; }

        /// <summary>
        /// Misafire gösterilecek ücret açıklamasıdır.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Ücret tutarıdır.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Ücret para birimidir.
        /// </summary>
        public string CurrencyCode { get; set; } = "TRY";

        /// <summary>
        /// Ücretin oda hesabına yazılıp yazılmadığını belirtir.
        /// </summary>
        public bool IsPostedToRoom { get; set; }

        /// <summary>
        /// Ücret oda hesabına yazıldıysa işlem zamanıdır.
        /// </summary>
        public DateTime? PostedToRoomAt { get; set; }

        /// <summary>
        /// Ücret kaleminin güncel durumudur.
        /// </summary>
        public ChargeStatusEnum Status { get; set; } = ChargeStatusEnum.Pending;

/// <summary>
/// PaymentTransactions değerini alır veya ayarlar.
/// </summary>
public IList<PaymentTransaction> PaymentTransactions { get; set; } = new List<PaymentTransaction>();
    }
}
