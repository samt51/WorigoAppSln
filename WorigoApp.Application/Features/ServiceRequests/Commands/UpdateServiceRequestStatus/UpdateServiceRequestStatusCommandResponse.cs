using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequests.Commands.UpdateServiceRequestStatus
{
/// <summary>
/// UpdateServiceRequestStatusCommandResponse sınıfını temsil eder.
/// </summary>
public class UpdateServiceRequestStatusCommandResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public ServiceRequestStatusEnum Status { get; set; }
/// <summary>
/// AssignedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? AssignedAt { get; set; }
/// <summary>
/// StartedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? StartedAt { get; set; }
/// <summary>
/// CompletedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? CompletedAt { get; set; }
/// <summary>
/// ClosedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? ClosedAt { get; set; }
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int? DepartmentId { get; set; }
/// <summary>
/// AssignedEmployeeId değerini alır veya ayarlar.
/// </summary>
public int? AssignedEmployeeId { get; set; }
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
/// <summary>
/// NotificationIds değerini alır veya ayarlar.
/// </summary>
public IList<int> NotificationIds { get; set; } = new List<int>();
/// <summary>
/// NotificationTitle değerini alır veya ayarlar.
/// </summary>
public string? NotificationTitle { get; set; }
/// <summary>
/// NotificationMessage değerini alır veya ayarlar.
/// </summary>
public string? NotificationMessage { get; set; }
    }
}
