using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Transfers.Commands.AssignDriver
{
/// <summary>
/// AssignDriverCommandRequest sınıfını temsil eder.
/// </summary>
public class AssignDriverCommandRequest : IRequest<ResponseDto<AssignDriverResponse>>
    {
/// <summary>
/// ServiceRequestId değerini alır veya ayarlar.
/// </summary>
public int ServiceRequestId { get; set; }
/// <summary>
/// DriverName değerini alır veya ayarlar.
/// </summary>
public string DriverName { get; set; } = string.Empty;
/// <summary>
/// DriverPhone değerini alır veya ayarlar.
/// </summary>
public string DriverPhone { get; set; } = string.Empty;
/// <summary>
/// VehiclePlate değerini alır veya ayarlar.
/// </summary>
public string VehiclePlate { get; set; } = string.Empty;
/// <summary>
/// VehicleModel değerini alır veya ayarlar.
/// </summary>
public string VehicleModel { get; set; } = string.Empty;
/// <summary>
/// EstimatedArrivalTime değerini alır veya ayarlar.
/// </summary>
public DateTime? EstimatedArrivalTime { get; set; }
    }
}
