using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Personel icin yonetici veya departman tarafindan acilan ic gorev kaydini tutar.
    /// </summary>
    public class EmployeeTask : EntityBase
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// Hotel değerini alır veya ayarlar.
/// </summary>
public Hotel Hotel { get; set; } = null!;
/// <summary>
/// AssignedEmployeeId değerini alır veya ayarlar.
/// </summary>
public int AssignedEmployeeId { get; set; }
/// <summary>
/// AssignedEmployee değerini alır veya ayarlar.
/// </summary>
public Employee AssignedEmployee { get; set; } = null!;
/// <summary>
/// AssignedByEmployeeId değerini alır veya ayarlar.
/// </summary>
public int AssignedByEmployeeId { get; set; }
/// <summary>
/// AssignedByEmployee değerini alır veya ayarlar.
/// </summary>
public Employee AssignedByEmployee { get; set; } = null!;
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int? DepartmentId { get; set; }
/// <summary>
/// Department değerini alır veya ayarlar.
/// </summary>
public Department? Department { get; set; }
/// <summary>
/// RelatedServiceRequestId değerini alır veya ayarlar.
/// </summary>
public int? RelatedServiceRequestId { get; set; }
/// <summary>
/// RelatedServiceRequest değerini alır veya ayarlar.
/// </summary>
public ServiceRequest? RelatedServiceRequest { get; set; }
/// <summary>
/// Title değerini alır veya ayarlar.
/// </summary>
public string Title { get; set; } = string.Empty;
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string? Description { get; set; }
/// <summary>
/// Priority değerini alır veya ayarlar.
/// </summary>
public EmployeeTaskPriorityEnum Priority { get; set; } = EmployeeTaskPriorityEnum.Normal;
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public EmployeeTaskStatusEnum Status { get; set; } = EmployeeTaskStatusEnum.Open;
/// <summary>
/// DueAt değerini alır veya ayarlar.
/// </summary>
public DateTime? DueAt { get; set; }
/// <summary>
/// StartedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? StartedAt { get; set; }
/// <summary>
/// CompletedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? CompletedAt { get; set; }
/// <summary>
/// CompletionNote değerini alır veya ayarlar.
/// </summary>
public string? CompletionNote { get; set; }
    }
}
