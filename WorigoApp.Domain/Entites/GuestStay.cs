using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Misafirin odaya girişinden çıkışına kadar olan konaklama oturumunu temsil eder.
    /// </summary>
    public class GuestStay : EntityBase
    {
        public GuestStay()
        {
        }

        public GuestStay(int id, int hotelId, int roomId, DateTime checkInDate, DateTime CheckoutDate, string verificationCode)
        {
            Id = id;
            HotelId = hotelId;
            RoomId = roomId;
            CheckInDate = checkInDate;
            CheckOutDate = CheckoutDate;
            VerificationCode = verificationCode;
        }

        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; } = null!;

        /// <summary>
        /// Rezervasyon numarası.
        /// </summary>
        public string? ReservationNo { get; set; }

        /// <summary>
        /// Ana misafirin ID bilgisi.
        /// </summary>
        public int? PrimaryCustomerId { get; set; }

        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        /// <summary>
        /// Misafirin fiili giriş zamanı.
        /// </summary>
        public DateTime? ActualCheckInAt { get; set; }

        /// <summary>
        /// Misafirin fiili çıkış zamanı.
        /// </summary>
        public DateTime? ActualCheckOutAt { get; set; }

        /// <summary>
        /// Oda erişimi için kullanılacak doğrulama kodu.
        /// </summary>
        public string VerificationCode { get; set; } = string.Empty;

        /// <summary>
        /// Rezervasyon kanalı. Örn: WalkIn, Booking, Agency.
        /// </summary>
        public string? Channel { get; set; }

        /// <summary>
        /// Misafirin kullandığı dil kodu.
        /// </summary>
        public string GuestLanguageCode { get; set; } = "tr-TR";

        /// <summary>
        /// Mobil bildirimler için cihaz token bilgisi.
        /// </summary>
        public string? DeviceToken { get; set; }

        /// <summary>
        /// Mobil uygulama erişiminin açık olup olmadığını belirtir.
        /// </summary>
        public bool IsMobileAccessEnabled { get; set; }

        /// <summary>
        /// Konaklama durumunu belirtir.
        /// </summary>
        public string Status { get; set; } = "Active";

        /// <summary>
        /// Misafirin rezervasyon konseptini belirtir. Örn: Her şey dahil, yarım pansiyon.
        /// </summary>
        public AccommodationConceptTypeEnum AccommodationConceptType { get; set; } = AccommodationConceptTypeEnum.RoomOnly;

        /// <summary>
        /// Konaklama boyunca kullanılacak ana para birimini belirtir.
        /// </summary>
        public string CurrencyCode { get; set; } = "TRY";

        /// <summary>
        /// Resepsiyon tarafinda onaylanan toplam konaklama fiyati.
        /// </summary>
        public decimal TotalPrice { get; set; }

        public bool IsVip { get; set; } = false;
        public bool HasAllergy { get; set; } = false;
        public bool DoNotDisturb { get; set; } = false;
        public bool IsLateCheckOut { get; set; } = false;

        public IList<Order> Orders { get; set; } = new List<Order>();
        public IList<Customer> Customers { get; set; } = new List<Customer>();
        public IList<ServiceRequest> ServiceRequests { get; set; } = new List<ServiceRequest>();
        public IList<GuestSession> GuestSessions { get; set; } = new List<GuestSession>();
        public IList<Conversation> Conversations { get; set; } = new List<Conversation>();
        public IList<Charge> Charges { get; set; } = new List<Charge>();
    }
}
