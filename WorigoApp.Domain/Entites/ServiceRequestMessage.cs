using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Servis talebi icindeki canli chat mesajlarini ve ceviri karsiliklarini tutar.
    /// </summary>
    public class ServiceRequestMessage : EntityBase
    {
        /// <summary>
        /// Mesajin ait oldugu servis talebi.
        /// </summary>
        public int ServiceRequestId { get; set; }

        public ServiceRequest ServiceRequest { get; set; } = null!;

        /// <summary>
        /// Mesaji gonderen kullanici.
        /// </summary>
        public int? SenderUserId { get; set; }

        public Users? SenderUser { get; set; }

        /// <summary>
        /// Gonderenin tipi.
        /// </summary>
        public MessageSenderTypeEnum SenderType { get; set; }

        /// <summary>
        /// Mesajin yazildigi orijinal dil.
        /// </summary>
        public string OriginalLanguageCode { get; set; } = "tr-TR";

        /// <summary>
        /// Kullanıcinin yazdigi orijinal metin.
        /// </summary>
        public string OriginalText { get; set; } = string.Empty;

        /// <summary>
        /// Hedef kullanici icin cevrilmis metin.
        /// </summary>
        public string? TranslatedText { get; set; }

        /// <summary>
        /// Cevirinin hedef dil kodu.
        /// </summary>
        public string? TranslatedLanguageCode { get; set; }

        /// <summary>
        /// Mesaj gonderim zamani.
        /// </summary>
        public DateTime SentAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Mesaj okunma zamani.
        /// </summary>
        public DateTime? ReadAt { get; set; }

        /// <summary>
        /// Mesaj tipi. Ornek: Text, Image, System.
        /// </summary>
        public string MessageType { get; set; } = "Text";

        /// <summary>
        /// Log ve raporlama icin sadelestirilmis mesaj metni.
        /// </summary>
        public string? NormalizedText { get; set; }

        /// <summary>
        /// Ceviriyi yapan servis saglayicisi.
        /// </summary>
        public string? TranslationProvider { get; set; }

        /// <summary>
        /// Ceviride kullanilan model adi.
        /// </summary>
        public string? TranslationModel { get; set; }

        /// <summary>
        /// Ceviri durum bilgisi. Ornek: Success, Skipped, Failed.
        /// </summary>
        public string TranslationStatus { get; set; } = "Pending";
    }
}
