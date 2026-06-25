using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Personelin departman muduru ve IK tarafina ilettigi izin taleplerini tutar.
    /// </summary>
    public class LeaveRequest : EntityBase
    {
        /// <summary>
        /// Talebin ait oldugu otel.
        /// </summary>
        public int HotelId { get; set; }

/// <summary>
/// Hotel değerini alır veya ayarlar.
/// </summary>
public Hotel Hotel { get; set; } = null!;

        /// <summary>
        /// Izin talebini olusturan personel.
        /// </summary>
        public int EmployeeId { get; set; }

/// <summary>
/// Employee değerini alır veya ayarlar.
/// </summary>
public Employee Employee { get; set; } = null!;

        /// <summary>
        /// Personelin bagli oldugu departman.
        /// </summary>
        public int? DepartmentId { get; set; }

/// <summary>
/// Department değerini alır veya ayarlar.
/// </summary>
public Department? Department { get; set; }

        /// <summary>
        /// Ilk onayi verecek departman muduru.
        /// </summary>
        public int? ManagerEmployeeId { get; set; }

/// <summary>
/// ManagerEmployee değerini alır veya ayarlar.
/// </summary>
public Employee? ManagerEmployee { get; set; }

        /// <summary>
        /// Ikinci asama IK sorumlusu.
        /// </summary>
        public int? HrEmployeeId { get; set; }

/// <summary>
/// HrEmployee değerini alır veya ayarlar.
/// </summary>
public Employee? HrEmployee { get; set; }

        /// <summary>
        /// Izin tipi.
        /// </summary>
        public LeaveRequestTypeEnum LeaveType { get; set; }

        /// <summary>
        /// Talep basligi.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Personelin izin gerekcesi.
        /// </summary>
        public string? Reason { get; set; }

        /// <summary>
        /// Izin baslangic tarihi.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Izin bitis tarihi.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Toplam gun sayisi.
        /// </summary>
        public decimal TotalDayCount { get; set; }

        /// <summary>
        /// Talebin mevcut onay durumu.
        /// </summary>
        public LeaveRequestStatusEnum Status { get; set; } = LeaveRequestStatusEnum.PendingManagerApproval;

        /// <summary>
        /// Talebin olusturuldugu an.
        /// </summary>
        public DateTime RequestedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Yonetici ilk onay tarihi.
        /// </summary>
        public DateTime? ManagerActionAt { get; set; }

        /// <summary>
        /// IK son onay tarihi.
        /// </summary>
        public DateTime? HrActionAt { get; set; }

        /// <summary>
        /// Yonetici notu.
        /// </summary>
        public string? ManagerNote { get; set; }

        /// <summary>
        /// IK notu.
        /// </summary>
        public string? HrNote { get; set; }
    }
}
