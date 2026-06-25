using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Otelde görev yapan personelin ana kimlik ve görev bilgilerini tutar.
    /// </summary>
    public class Employee : EntityBase
    {
/// <summary>
/// Employee sınıfının yeni bir örneğini başlatır.
/// </summary>
public Employee()
        {
        }

        /// <summary>
        /// Personelin adı.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Personelin soyadı.
        /// </summary>
        public string Surname { get; set; } = string.Empty;

        /// <summary>
        /// Personel profil görseli.
        /// </summary>
        public string? ImageUrl { get; set; }

/// <summary>
/// EmployeeTypeId değerini alır veya ayarlar.
/// </summary>
public int? EmployeeTypeId { get; set; }
/// <summary>
/// EmployeeType değerini alır veya ayarlar.
/// </summary>
public EmployeeType? EmployeeType { get; set; }
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int? HotelId { get; set; }
/// <summary>
/// Hotel değerini alır veya ayarlar.
/// </summary>
public Hotel? Hotel { get; set; }

        /// <summary>
        /// Doğum tarihi.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Telefon numarası.
        /// </summary>
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Mevcut akışlarla uyumlu basit cinsiyet alanı.
        /// </summary>
        public bool Gender { get; set; }

        /// <summary>
        /// İşe başlama tarihi.
        /// </summary>
        public DateTime StartDateOfWork { get; set; }

        /// <summary>
        /// İşten ayrılma tarihi.
        /// </summary>
        public DateTime? ExitDateOfWork { get; set; }

        /// <summary>
        /// Personelin son çevrim içi olduğu an.
        /// </summary>
        public DateTime? LastOnlineTime { get; set; }

        /// <summary>
        /// Personelin ağırlıklı çalıştığı kat bilgisi.
        /// </summary>
        public int? FloorNo { get; set; }

        /// <summary>
        /// Personelin o anda çevrim içi görünüp görünmediği.
        /// </summary>
        public bool OnlineOrOfflineNow { get; set; }

        /// <summary>
        /// Acil durumda aranacak kişi adı.
        /// </summary>
        public string? EmergencyContactName { get; set; }

        /// <summary>
        /// Acil durumda aranacak kişi telefonu.
        /// </summary>
        public string? EmergencyContactPhone { get; set; }

        /// <summary>
        /// Kimlik veya pasaport numarası gibi resmi numara bilgisi.
        /// </summary>
        public string? NationalId { get; set; }

        /// <summary>
        /// Personelin ikamet adresi.
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// Personelin profil dili.
        /// </summary>
        public string? ProfileLanguage { get; set; }

        /// <summary>
        /// Personelin giriş yapabildiği kullanıcı hesabı.
        /// </summary>
        public int? UserId { get; set; }

/// <summary>
/// User değerini alır veya ayarlar.
/// </summary>
public Users? User { get; set; }

        /// <summary>
        /// Personel için dış sistemlerde veya raporlarda kullanılacak kod.
        /// </summary>
        public string? EmployeeCode { get; set; }

        /// <summary>
        /// Personelin aktif olarak çalışıp çalışmadığını belirtir.
        /// </summary>
        public bool Status { get; set; } = true;

        /// <summary>
        /// Personelin işe alım tipi. Örn: FullTime, PartTime.
        /// </summary>
        public string? HireType { get; set; }

        /// <summary>
        /// Personelin vardiya bilgisini temsil eder.
        /// </summary>
        public int? ShiftId { get; set; }

        /// <summary>
        /// Personelin bağlı olduğu vardiya kaydı.
        /// </summary>
        public Shift? Shift { get; set; }

        /// <summary>
        /// Personelin yeni görev almaya uygun olup olmadığını belirtir.
        /// </summary>
        public bool IsAvailableForTask { get; set; } = true;

        /// <summary>
        /// Personelin aldığı puanların ortalaması.
        /// </summary>
        public decimal AverageRating { get; set; }

        /// <summary>
        /// Personele son görev atamasının yapıldığı zaman.
        /// </summary>
        public DateTime? LastAssignedAt { get; set; }

        /// <summary>
        /// Personelin konuşabildiği dillerin virgülle tutulduğu kısa alan.
        /// </summary>
        public string? LanguageCodes { get; set; }

/// <summary>
/// AssignedServiceRequests değerini alır veya ayarlar.
/// </summary>
public IList<ServiceRequest> AssignedServiceRequests { get; set; } = new List<ServiceRequest>();
/// <summary>
/// StockMovements değerini alır veya ayarlar.
/// </summary>
public IList<StockMovement> StockMovements { get; set; } = new List<StockMovement>();
/// <summary>
/// RequestedStockRequests değerini alır veya ayarlar.
/// </summary>
public IList<StockRequest> RequestedStockRequests { get; set; } = new List<StockRequest>();
/// <summary>
/// ManagedStockRequests değerini alır veya ayarlar.
/// </summary>
public IList<StockRequest> ManagedStockRequests { get; set; } = new List<StockRequest>();
/// <summary>
/// LeaveRequests değerini alır veya ayarlar.
/// </summary>
public IList<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();
/// <summary>
/// ManagedLeaveRequests değerini alır veya ayarlar.
/// </summary>
public IList<LeaveRequest> ManagedLeaveRequests { get; set; } = new List<LeaveRequest>();
/// <summary>
/// HrManagedLeaveRequests değerini alır veya ayarlar.
/// </summary>
public IList<LeaveRequest> HrManagedLeaveRequests { get; set; } = new List<LeaveRequest>();
/// <summary>
/// AttendanceRecords değerini alır veya ayarlar.
/// </summary>
public IList<AttendanceRecord> AttendanceRecords { get; set; } = new List<AttendanceRecord>();
/// <summary>
/// PerformanceReviews değerini alır veya ayarlar.
/// </summary>
public IList<PerformanceReview> PerformanceReviews { get; set; } = new List<PerformanceReview>();
/// <summary>
/// ReviewerPerformanceReviews değerini alır veya ayarlar.
/// </summary>
public IList<PerformanceReview> ReviewerPerformanceReviews { get; set; } = new List<PerformanceReview>();
/// <summary>
/// InternalAnnouncements değerini alır veya ayarlar.
/// </summary>
public IList<Announcement> InternalAnnouncements { get; set; } = new List<Announcement>();
/// <summary>
/// AssignedEmployeeTasks değerini alır veya ayarlar.
/// </summary>
public IList<EmployeeTask> AssignedEmployeeTasks { get; set; } = new List<EmployeeTask>();
/// <summary>
/// CreatedEmployeeTasks değerini alır veya ayarlar.
/// </summary>
public IList<EmployeeTask> CreatedEmployeeTasks { get; set; } = new List<EmployeeTask>();
/// <summary>
/// EmployeeDocuments değerini alır veya ayarlar.
/// </summary>
public IList<EmployeeDocument> EmployeeDocuments { get; set; } = new List<EmployeeDocument>();
/// <summary>
/// VerifiedEmployeeDocuments değerini alır veya ayarlar.
/// </summary>
public IList<EmployeeDocument> VerifiedEmployeeDocuments { get; set; } = new List<EmployeeDocument>();
/// <summary>
/// Employee sınıfının yeni bir örneğini başlatır.
/// </summary>
public Employee(int id, string name, string surName, string imageUrl, int employeeTypeId, int hotelId, int userId)
        {
            Id = id;
            Name = name;
            Surname = surName;
            ImageUrl = imageUrl;
            EmployeeTypeId = employeeTypeId;
            HotelId = hotelId;
            UserId = userId;
        }
    }
}
