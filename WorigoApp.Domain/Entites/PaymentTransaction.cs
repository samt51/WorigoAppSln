using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Online ödeme veya harici tahsilat süreçlerinin denetim izini tutar.
    /// </summary>
    public class PaymentTransaction : EntityBase
    {
        /// <summary>
        /// Ödeme denemesinin bağlı olduğu ücret kalemidir.
        /// </summary>
        public int ChargeId { get; set; }

        public Charge Charge { get; set; } = null!;

        /// <summary>
        /// İşlemin hangi sağlayıcı üzerinden yürütüldüğünü belirtir.
        /// </summary>
        public PaymentProviderEnum PaymentProvider { get; set; } = PaymentProviderEnum.Unknown;

        /// <summary>
        /// Banka veya ödeme sağlayıcısının ürettiği işlem numarasıdır.
        /// </summary>
        public string? ExternalTransactionId { get; set; }

        /// <summary>
        /// İşlemin ödeme yöntemi bilgisidir. Örn: Card, Link, Wallet.
        /// </summary>
        public string PaymentMethod { get; set; } = "Card";

        /// <summary>
        /// Ödeme denemesinin güncel durumudur.
        /// </summary>
        public OrderPaymentStatusEnum PaymentStatus { get; set; } = OrderPaymentStatusEnum.Pending;

        /// <summary>
        /// Tahsil edilmesi beklenen tutardır.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// İşlemin para birimidir.
        /// </summary>
        public string CurrencyCode { get; set; } = "TRY";

        /// <summary>
        /// Kullanıcıyı online ödeme ekranına yönlendirmek için kullanılacak bağlantıdır.
        /// </summary>
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// Ödemenin tamamlandığı tarih bilgisidir.
        /// </summary>
        public DateTime? PaidAt { get; set; }

        /// <summary>
        /// Başarısız işlemlerde hata veya reddedilme açıklamasıdır.
        /// </summary>
        public string? FailureReason { get; set; }
    }
}
