using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Misafirin odaya girişinden çıkışına kadar olan konaklama oturumunu temsil eder.
    /// </summary>
    public class GuestStay : EntityBase
    {
/// <summary>
/// GuestStay sınıfının yeni bir örneğini başlatır.
/// </summary>
public GuestStay()
        {
        }
/// <summary>
/// GuestStay sınıfının yeni bir örneğini başlatır.
/// </summary>
public GuestStay(int id, int hotelId, int roomId, DateTime checkInDate, DateTime CheckoutDate, string verificationCode)
        {
            Id = id;
            HotelId = hotelId;
            RoomId = roomId;
            CheckInDate = checkInDate;
            CheckOutDate = CheckoutDate;
            VerificationCode = verificationCode;
        }

/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// RoomId değerini alır veya ayarlar.
/// </summary>
public int RoomId { get; set; }
/// <summary>
/// Room değerini alır veya ayarlar.
/// </summary>
public Room Room { get; set; } = null!;

        /// <summary>
        /// Rezervasyon numarası.
        /// </summary>
        public string? ReservationNo { get; set; }

        /// <summary>
        /// Ana misafirin ID bilgisi.
        /// </summary>
        public int? PrimaryCustomerId { get; set; }

/// <summary>
/// CheckInDate değerini alır veya ayarlar.
/// </summary>
public DateTime CheckInDate { get; set; }
/// <summary>
/// CheckOutDate değerini alır veya ayarlar.
/// </summary>
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

/// <summary>
/// AdultCount değerini alır veya ayarlar.
/// </summary>
public int AdultCount { get; set; } = 1;
/// <summary>
/// ChildCount değerini alır veya ayarlar.
/// </summary>
public int ChildCount { get; set; }
/// <summary>
/// DepositAmount değerini alır veya ayarlar.
/// </summary>
public decimal DepositAmount { get; set; }
/// <summary>
/// SpecialRequests değerini alır veya ayarlar.
/// </summary>
public string? SpecialRequests { get; set; }
/// <summary>
/// GuestConsentAt değerini alır veya ayarlar.
/// </summary>
public DateTime? GuestConsentAt { get; set; }

/// <summary>
/// IsVip değerini alır veya ayarlar.
/// </summary>
public bool IsVip { get; set; } = false;
/// <summary>
/// HasAllergy değerini alır veya ayarlar.
/// </summary>
public bool HasAllergy { get; set; } = false;
/// <summary>
/// DoNotDisturb değerini alır veya ayarlar.
/// </summary>
public bool DoNotDisturb { get; set; } = false;
/// <summary>
/// IsLateCheckOut değerini alır veya ayarlar.
/// </summary>
public bool IsLateCheckOut { get; set; } = false;
/// <summary>
/// RoomAvailabilityStatus değerini alır veya ayarlar.
/// </summary>
public string? RoomAvailabilityStatus { get; set; } = "Normal";
/// <summary>
/// RoomAvailabilityUpdatedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? RoomAvailabilityUpdatedAt { get; set; }

/// <summary>
/// Orders değerini alır veya ayarlar.
/// </summary>
public IList<Order> Orders { get; set; } = new List<Order>();
/// <summary>
/// Customers değerini alır veya ayarlar.
/// </summary>
public IList<Customer> Customers { get; set; } = new List<Customer>();
/// <summary>
/// ServiceRequests değerini alır veya ayarlar.
/// </summary>
public IList<ServiceRequest> ServiceRequests { get; set; } = new List<ServiceRequest>();
/// <summary>
/// GuestSessions değerini alır veya ayarlar.
/// </summary>
public IList<GuestSession> GuestSessions { get; set; } = new List<GuestSession>();
/// <summary>
/// Conversations değerini alır veya ayarlar.
/// </summary>
public IList<Conversation> Conversations { get; set; } = new List<Conversation>();
/// <summary>
/// Charges değerini alır veya ayarlar.
/// </summary>
public IList<Charge> Charges { get; set; } = new List<Charge>();
    }
}
