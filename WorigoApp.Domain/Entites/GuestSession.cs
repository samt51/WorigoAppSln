using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Misafirin QR kod, doğrulama kodu veya mobil bağlantı ile açtığı geçici erişim oturumunu tutar.
    /// </summary>
    public class GuestSession : EntityBase
    {
        /// <summary>
        /// Oturumun bağlı olduğu konaklama kaydıdır.
        /// </summary>
        public int GuestStayId { get; set; }

/// <summary>
/// GuestStay değerini alır veya ayarlar.
/// </summary>
public GuestStay GuestStay { get; set; } = null!;

        /// <summary>
        /// Oturum belirli bir misafire bağlıysa ilgili misafir bilgisidir.
        /// </summary>
        public int? CustomerId { get; set; }

/// <summary>
/// Customer değerini alır veya ayarlar.
/// </summary>
public Customer? Customer { get; set; }

        /// <summary>
        /// QR veya mobil erişimden gelen oturum anahtarıdır.
        /// </summary>
        public string SessionToken { get; set; } = string.Empty;

        /// <summary>
        /// QR kodun temsil ettiği kısa süreli erişim anahtarıdır.
        /// </summary>
        public string? QrCodeToken { get; set; }

        /// <summary>
        /// Oturumun geçerlilik bitiş zamanıdır.
        /// </summary>
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Oturumun son erişim zamanıdır.
        /// </summary>
        public DateTime? LastAccessAt { get; set; }

        /// <summary>
        /// Misafirin mobil bildirimleri için cihaz token bilgisidir.
        /// </summary>
        public string? DeviceToken { get; set; }

        /// <summary>
        /// Oturumda kullanılacak dil kodudur.
        /// </summary>
        public string LanguageCode { get; set; } = "tr-TR";

        /// <summary>
        /// Oturumun aktif olarak kullanılabilir olup olmadığını belirtir.
        /// </summary>
        public bool IsActiveSession { get; set; } = true;
    }
}
