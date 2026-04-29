using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Misafir ile otel/personel arasındaki genel sohbet oturumunu temsil eder.
    /// </summary>
    public class Conversation : EntityBase
    {
        /// <summary>
        /// Sohbetin bağlı olduğu otel bilgisidir.
        /// </summary>
        public int HotelId { get; set; }

        public Hotel Hotel { get; set; } = null!;

        /// <summary>
        /// Sohbetin bağlı olduğu konaklama kaydıdır.
        /// </summary>
        public int? GuestStayId { get; set; }

        public GuestStay? GuestStay { get; set; }

        /// <summary>
        /// Sohbeti başlatan misafir varsa ilgili misafir bilgisidir.
        /// </summary>
        public int? CustomerId { get; set; }

        public Customer? Customer { get; set; }

        /// <summary>
        /// Sohbet servis talebine dönüştüyse ilgili talep bilgisidir.
        /// </summary>
        public int? ServiceRequestId { get; set; }

        public ServiceRequest? ServiceRequest { get; set; }

        /// <summary>
        /// Sohbetin kısa başlığı veya konusu.
        /// </summary>
        public string? Subject { get; set; }

        /// <summary>
        /// Sohbetin mevcut durumudur.
        /// </summary>
        public ConversationStatusEnum Status { get; set; } = ConversationStatusEnum.Open;

        /// <summary>
        /// Sohbetin genel, servis talebi, destek veya yapay zeka amaçlı olup olmadığını belirtir.
        /// </summary>
        public ConversationTypeEnum ConversationType { get; set; } = ConversationTypeEnum.General;

        /// <summary>
        /// Sohbetin açıldığı dil kodudur.
        /// </summary>
        public string LanguageCode { get; set; } = "tr-TR";

        /// <summary>
        /// Sohbetin açıldığı zamandır.
        /// </summary>
        public DateTime StartedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Sohbetin kapandığı zamandır.
        /// </summary>
        public DateTime? ClosedAt { get; set; }

        public IList<ConversationMessage> Messages { get; set; } = new List<ConversationMessage>();
    }
}
