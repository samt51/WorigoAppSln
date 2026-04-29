using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Otele giriş yapmış misafir bilgisini tutar.
    /// </summary>
    public class Customer : EntityBase
    {
        /// <summary>
        /// Misafirin adı.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Misafirin soyadı.
        /// </summary>
        public string SurName { get; set; } = string.Empty;

        /// <summary>
        /// Mevcut akışlarla uyumlu cinsiyet alanı.
        /// </summary>
        public bool Gender { get; set; }

        /// <summary>
        /// Misafirin e-posta adresi.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Misafirin telefon numarası.
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Misafirin vatandaşlık bilgisi.
        /// </summary>
        public string? Nationality { get; set; }

        /// <summary>
        /// Misafirin tercih ettiği dil kodu.
        /// </summary>
        public string PreferredLanguageCode { get; set; } = "tr-TR";

        /// <summary>
        /// Misafirin doğum tarihi.
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Misafirin ana rezervasyon sahibi olup olmadığını belirtir.
        /// </summary>
        public bool IsPrimaryGuest { get; set; }

        public int GuestStayId { get; set; }
        public GuestStay GuestStay { get; set; } = null!;
        public IList<ServiceRequest> ServiceRequests { get; set; } = new List<ServiceRequest>();
        public IList<GuestSession> GuestSessions { get; set; } = new List<GuestSession>();
        public IList<Conversation> Conversations { get; set; } = new List<Conversation>();
        public IList<ConversationMessage> ConversationMessages { get; set; } = new List<ConversationMessage>();
    }
}
