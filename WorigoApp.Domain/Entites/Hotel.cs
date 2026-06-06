using System.ComponentModel.DataAnnotations.Schema;
using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Sistemde tanımlı otel bilgisini ve otele ait operasyonel ayarları tutar.
    /// </summary>
    public class Hotel : EntityBase
    {
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

        public Company Company { get; set; } = null!;
        public IList<ImageCategory> ImageCategories { get; set; } = new List<ImageCategory>();
        public IList<Employee> Employees { get; set; } = new List<Employee>();
        public IList<FoodMenuCategory> FoodMenuCategories { get; set; } = new List<FoodMenuCategory>();
        public IList<Room> Rooms { get; set; } = new List<Room>();
        public IList<Department> Departments { get; set; } = new List<Department>();
        public IList<Announcement> Announcements { get; set; } = new List<Announcement>();
        public IList<ServiceRequest> ServiceRequests { get; set; } = new List<ServiceRequest>();
        public IList<StockItem> StockItems { get; set; } = new List<StockItem>();
        public IList<StockMovement> StockMovements { get; set; } = new List<StockMovement>();
        public IList<StockRequest> StockRequests { get; set; } = new List<StockRequest>();
        public IList<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();
        public IList<AttendanceRecord> AttendanceRecords { get; set; } = new List<AttendanceRecord>();
        public IList<PerformanceReview> PerformanceReviews { get; set; } = new List<PerformanceReview>();
        public IList<InternalAnnouncement> InternalAnnouncements { get; set; } = new List<InternalAnnouncement>();
        public IList<EmployeeTask> EmployeeTasks { get; set; } = new List<EmployeeTask>();
        public IList<EmployeeDocument> EmployeeDocuments { get; set; } = new List<EmployeeDocument>();
        public IList<HotelServicePolicy> HotelServicePolicies { get; set; } = new List<HotelServicePolicy>();
        public IList<ServiceCategory> ServiceCategories { get; set; } = new List<ServiceCategory>();
        public IList<ServiceDefinition> ServiceDefinitions { get; set; } = new List<ServiceDefinition>();
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
