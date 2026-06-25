using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// TransferTracking sınıfını temsil eder.
/// </summary>
public class TransferTracking : EntityBase
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
/// ServiceRequestId değerini alır veya ayarlar.
/// </summary>
public int ServiceRequestId { get; set; }
/// <summary>
/// ServiceRequest değerini alır veya ayarlar.
/// </summary>
public ServiceRequest ServiceRequest { get; set; } = null!;
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
/// <summary>
/// GuestStay değerini alır veya ayarlar.
/// </summary>
public GuestStay GuestStay { get; set; } = null!;
/// <summary>
/// CustomerId değerini alır veya ayarlar.
/// </summary>
public int CustomerId { get; set; }
/// <summary>
/// Customer değerini alır veya ayarlar.
/// </summary>
public Customer Customer { get; set; } = null!;
/// <summary>
/// DriverName değerini alır veya ayarlar.
/// </summary>
public string? DriverName { get; set; }
/// <summary>
/// DriverPhone değerini alır veya ayarlar.
/// </summary>
public string? DriverPhone { get; set; }
/// <summary>
/// VehiclePlate değerini alır veya ayarlar.
/// </summary>
public string? VehiclePlate { get; set; }
/// <summary>
/// VehicleModel değerini alır veya ayarlar.
/// </summary>
public string? VehicleModel { get; set; }
/// <summary>
/// EstimatedArrivalTime değerini alır veya ayarlar.
/// </summary>
public DateTime? EstimatedArrivalTime { get; set; }
/// <summary>
/// PickupLocation değerini alır veya ayarlar.
/// </summary>
public string PickupLocation { get; set; } = string.Empty;
/// <summary>
/// DropoffLocation değerini alır veya ayarlar.
/// </summary>
public string DropoffLocation { get; set; } = string.Empty;
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public string Status { get; set; } = "Pending"; // Pending, Assigned, InProgress, Completed, Cancelled
/// <summary>
/// AssignedEmployeeId değerini alır veya ayarlar.
/// </summary>
public int? AssignedEmployeeId { get; set; }
/// <summary>
/// AssignedEmployee değerini alır veya ayarlar.
/// </summary>
public Employee? AssignedEmployee { get; set; }
/// <summary>
/// AssignedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? AssignedAt { get; set; }
/// <summary>
/// CompletedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? CompletedAt { get; set; }
    }
}
