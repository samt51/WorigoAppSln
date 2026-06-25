using System.ComponentModel.DataAnnotations.Schema;
using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Sistemde tanımlı otel bilgisini ve otele ait operasyonel ayarları tutar.
    /// </summary>
    public class Hotel : EntityBase
    {
/// <summary>
/// Hotel sınıfının yeni bir örneğini başlatır.
/// </summary>
public Hotel()
        {
        }

        /// <summary>
        /// Otelin görünen adı.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Otelin lokasyon bilgisi veya bölge adı.
        /// </summary>
        public string Location { get; set; } = string.Empty;

        /// <summary>
        /// Otelin açık adresi.
        /// </summary>
        public string Adress { get; set; } = string.Empty;

        /// <summary>
        /// Otel için tanımlanan kısa kod.
        /// </summary>
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// Otelin telefon numarası.
        /// </summary>
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Otelin e-posta adresi.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Otelin yıldız sayısı.
        /// </summary>
        public int NumberOfStar { get; set; }

        /// <summary>
        /// Otelin varsayılan zaman dilimi bilgisi. Örn: Europe/Istanbul.
        /// </summary>
        public string TimeZone { get; set; } = "Europe/Istanbul";

        /// <summary>
        /// Otelin varsayılan dil kodu. Örn: tr-TR.
        /// </summary>
        public string DefaultLanguageCode { get; set; } = "tr-TR";

        /// <summary>
        /// Adresin ilk satırı.
        /// </summary>
        public string AddressLine1 { get; set; } = string.Empty;

        /// <summary>
        /// Adresin ikinci satırı.
        /// </summary>
        public string? AddressLine2 { get; set; }

        /// <summary>
        /// Şehir bilgisi.
        /// </summary>
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// Ülke bilgisi.
        /// </summary>
        public string Country { get; set; } = string.Empty;

        /// <summary>
        /// Otel logosunun URL bilgisi.
        /// </summary>
        public string? LogoUrl { get; set; }

        /// <summary>
        /// Harita için enlem bilgisi.
        /// </summary>
        public string? Latitude { get; set; }

        /// <summary>
        /// Harita için boylam bilgisi.
        /// </summary>
        public string? Longitude { get; set; }

        /// <summary>
        /// Demo amaçlı otel olup olmadığını belirtir.
        /// </summary>
        public bool IsDemoHotel { get; set; }

        /// <summary>
        /// Otelin bağlı olduğu şirketin ID bilgisidir.
        /// </summary>
        public int Companyid { get; set; }

/// <summary>
/// Company değerini alır veya ayarlar.
/// </summary>
public Company Company { get; set; } = null!;
/// <summary>
/// ImageCategories değerini alır veya ayarlar.
/// </summary>
public IList<ImageCategory> ImageCategories { get; set; } = new List<ImageCategory>();
/// <summary>
/// Employees değerini alır veya ayarlar.
/// </summary>
public IList<Employee> Employees { get; set; } = new List<Employee>();
/// <summary>
/// FoodMenuCategories değerini alır veya ayarlar.
/// </summary>
public IList<FoodMenuCategory> FoodMenuCategories { get; set; } = new List<FoodMenuCategory>();
/// <summary>
/// Rooms değerini alır veya ayarlar.
/// </summary>
public IList<Room> Rooms { get; set; } = new List<Room>();
/// <summary>
/// Departments değerini alır veya ayarlar.
/// </summary>
public IList<Department> Departments { get; set; } = new List<Department>();
/// <summary>
/// Announcements değerini alır veya ayarlar.
/// </summary>
public IList<Announcement> Announcements { get; set; } = new List<Announcement>();
/// <summary>
/// ServiceRequests değerini alır veya ayarlar.
/// </summary>
public IList<ServiceRequest> ServiceRequests { get; set; } = new List<ServiceRequest>();
/// <summary>
/// StockItems değerini alır veya ayarlar.
/// </summary>
public IList<StockItem> StockItems { get; set; } = new List<StockItem>();
/// <summary>
/// StockMovements değerini alır veya ayarlar.
/// </summary>
public IList<StockMovement> StockMovements { get; set; } = new List<StockMovement>();
/// <summary>
/// StockRequests değerini alır veya ayarlar.
/// </summary>
public IList<StockRequest> StockRequests { get; set; } = new List<StockRequest>();
/// <summary>
/// LeaveRequests değerini alır veya ayarlar.
/// </summary>
public IList<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();
/// <summary>
/// AttendanceRecords değerini alır veya ayarlar.
/// </summary>
public IList<AttendanceRecord> AttendanceRecords { get; set; } = new List<AttendanceRecord>();
/// <summary>
/// PerformanceReviews değerini alır veya ayarlar.
/// </summary>
public IList<PerformanceReview> PerformanceReviews { get; set; } = new List<PerformanceReview>();
/// <summary>
/// InternalAnnouncements değerini alır veya ayarlar.
/// </summary>
public IList<Announcement> InternalAnnouncements { get; set; } = new List<Announcement>();
/// <summary>
/// EmployeeTasks değerini alır veya ayarlar.
/// </summary>
public IList<EmployeeTask> EmployeeTasks { get; set; } = new List<EmployeeTask>();
/// <summary>
/// EmployeeDocuments değerini alır veya ayarlar.
/// </summary>
public IList<EmployeeDocument> EmployeeDocuments { get; set; } = new List<EmployeeDocument>();
/// <summary>
/// HotelServicePolicies değerini alır veya ayarlar.
/// </summary>
public IList<HotelServicePolicy> HotelServicePolicies { get; set; } = new List<HotelServicePolicy>();
/// <summary>
/// ServiceCategories değerini alır veya ayarlar.
/// </summary>
public IList<ServiceCategory> ServiceCategories { get; set; } = new List<ServiceCategory>();
/// <summary>
/// ServiceDefinitions değerini alır veya ayarlar.
/// </summary>
public IList<ServiceDefinition> ServiceDefinitions { get; set; } = new List<ServiceDefinition>();
/// <summary>
/// Conversations değerini alır veya ayarlar.
/// </summary>
public IList<Conversation> Conversations { get; set; } = new List<Conversation>();

        [NotMapped]
        public string Address
        {
            get => Adress;
            set => Adress = value;
        }

        [NotMapped]
        public int CompanyId
        {
            get => Companyid;
            set => Companyid = value;
        }
/// <summary>
/// Hotel sınıfının yeni bir örneğini başlatır.
/// </summary>
public Hotel(int id, string name, string location, string adress, string phoneNumber, string email, int numberOfStart, int companyId)
        {
            Id = id;
            Name = name;
            Location = location;
            Adress = adress;
            PhoneNumber = phoneNumber;
            Email = email;
            NumberOfStar = numberOfStart;
            Companyid = companyId;
        }
    }
}
