using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequests.Commands.CreateServiceRequest
{
/// <summary>
/// CreateServiceRequestCommandResponse sınıfını temsil eder.
/// </summary>
public class CreateServiceRequestCommandResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public ServiceRequestStatusEnum Status { get; set; }
/// <summary>
/// RequestedAt değerini alır veya ayarlar.
/// </summary>
public DateTime RequestedAt { get; set; }
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int? DepartmentId { get; set; }
/// <summary>
/// AssignedEmployeeId değerini alır veya ayarlar.
/// </summary>
public int? AssignedEmployeeId { get; set; }
/// <summary>
/// DueAt değerini alır veya ayarlar.
/// </summary>
public DateTime? DueAt { get; set; }
/// <summary>
/// ManagerEmployeeId değerini alır veya ayarlar.
/// </summary>
public int? ManagerEmployeeId { get; set; }
/// <summary>
/// NotificationIds değerini alır veya ayarlar.
/// </summary>
public IList<int> NotificationIds { get; set; } = new List<int>();
/// <summary>
/// ReceptionEmployeeIds değerini alır veya ayarlar.
/// </summary>
public IList<int> ReceptionEmployeeIds { get; set; } = new List<int>();
    }
}
