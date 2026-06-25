namespace WorigoApp.Application.Features.Transfers.Commands.AssignDriver
{
/// <summary>
/// AssignDriverResponse sınıfını temsil eder.
/// </summary>
public class AssignDriverResponse
    {
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
/// <summary>
/// DriverName değerini alır veya ayarlar.
/// </summary>
public string DriverName { get; set; } = string.Empty;
/// <summary>
/// VehiclePlate değerini alır veya ayarlar.
/// </summary>
public string VehiclePlate { get; set; } = string.Empty;
/// <summary>
/// EstimatedArrivalTime değerini alır veya ayarlar.
/// </summary>
public DateTime? EstimatedArrivalTime { get; set; }
    }
}
