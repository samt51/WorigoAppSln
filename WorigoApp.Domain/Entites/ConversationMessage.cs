using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Genel sohbet oturumu içindeki tekil mesajı ve çeviri bilgilerini tutar.
    /// </summary>
    public class ConversationMessage : EntityBase
    {
        /// <summary>
        /// Mesajın ait olduğu sohbet oturumudur.
        /// </summary>
        public int ConversationId { get; set; }

        public Conversation Conversation { get; set; } = null!;

        /// <summary>
        /// Mesajı gönderen sistem kullanıcısı varsa ilgili kullanıcı bilgisidir.
        /// </summary>
        public int? SenderUserId { get; set; }

        public Users? SenderUser { get; set; }

        /// <summary>
        /// Mesajı gönderen misafir varsa ilgili misafir bilgisidir.
        /// </summary>
        public int? SenderCustomerId { get; set; }

        public Customer? SenderCustomer { get; set; }

        /// <summary>
        /// Gönderen tarafın türüdür.
        /// </summary>
        public MessageSenderTypeEnum SenderType { get; set; }

        /// <summary>
        /// Mesajın yazıldığı orijinal dil kodudur.
        /// </summary>
        public string OriginalLanguageCode { get; set; } = "tr-TR";

        /// <summary>
        /// Mesajın orijinal metnidir.
        /// </summary>
        public string OriginalText { get; set; } = string.Empty;

        /// <summary>
        /// Hedef kullanıcı için çevrilmiş metindir.
        /// </summary>
        public string? TranslatedText { get; set; }

        /// <summary>
        /// Çevirinin hedef dil kodudur.
        /// </summary>
        public string? TranslatedLanguageCode { get; set; }

        /// <summary>
        /// Mesajın gönderildiği zamandır.
        /// </summary>
        public DateTime SentAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Mesajın okunduğu zamandır.
        /// </summary>
        public DateTime? ReadAt { get; set; }

        /// <summary>
        /// Mesaj türüdür. Örn: Text, Image, System.
        /// </summary>
        public string MessageType { get; set; } = "Text";

        /// <summary>
        /// Loglama ve arama için sadeleştirilmiş mesaj metnidir.
        /// </summary>
        public string? NormalizedText { get; set; }

        /// <summary>
        /// Çeviriyi yapan servis sağlayıcı adıdır.
        /// </summary>
        public string? TranslationProvider { get; set; }

        /// <summary>
        /// Çeviride kullanılan model adıdır.
        /// </summary>
        public string? TranslationModel { get; set; }

        /// <summary>
        /// Çeviri durumudur. Örn: Success, Skipped, Failed.
        /// </summary>
        public string TranslationStatus { get; set; } = "Pending";
    }
}
