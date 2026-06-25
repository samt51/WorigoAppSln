using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Otel içindeki departman bilgisini ve yönetim ilişkilerini tutar.
    /// </summary>
    public class Department : EntityBase
    {
/// <summary>
/// Department sınıfının yeni bir örneğini başlatır.
/// </summary>
public Department()
        {
        }
/// <summary>
/// Department sınıfının yeni bir örneğini başlatır.
/// </summary>
public Department(int id, string name, string imageUrl, int hotelid)
        {
            Id = id;
            Name = name;
            ImageUrl = imageUrl;
            HotelId = hotelid;
        }

        /// <summary>
        /// Departmanın adı.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Departmanı temsil eden görsel.
        /// </summary>
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Departmanın açıklaması.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Departmanın yöneticisi olan çalışanın ID'si.
        /// </summary>
        public int? ManagerEmployeeId { get; set; }

        /// <summary>
        /// Görüntüleme sırası.
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Departman misafirle doğrudan temas eden bir departman mı?
        /// </summary>
        public bool IsGuestFacing { get; set; }

/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// Hotel değerini alır veya ayarlar.
/// </summary>
public Hotel Hotel { get; set; } = null!;
/// <summary>
/// EmployeeTypes değerini alır veya ayarlar.
/// </summary>
public IList<EmployeeType> EmployeeTypes { get; set; } = new List<EmployeeType>();
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
/// ServiceDefinitions değerini alır veya ayarlar.
/// </summary>
public IList<ServiceDefinition> ServiceDefinitions { get; set; } = new List<ServiceDefinition>();
    }
}
