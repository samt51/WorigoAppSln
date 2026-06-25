using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Spa.Commands.CreateSpaAppointment
{
/// <summary>
/// CreateSpaAppointmentCommandRequest sınıfını temsil eder.
/// </summary>
public class CreateSpaAppointmentCommandRequest : IRequest<ResponseDto<SpaAppointment>>
    {
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
/// <summary>
/// ServiceName değerini alır veya ayarlar.
/// </summary>
public string ServiceName { get; set; } = string.Empty;
/// <summary>
/// TherapistName değerini alır veya ayarlar.
/// </summary>
public string? TherapistName { get; set; }
/// <summary>
/// AppointmentDate değerini alır veya ayarlar.
/// </summary>
public DateTime AppointmentDate { get; set; }
/// <summary>
/// TimeSlot değerini alır veya ayarlar.
/// </summary>
public string TimeSlot { get; set; } = string.Empty;
/// <summary>
/// Price değerini alır veya ayarlar.
/// </summary>
public decimal Price { get; set; }
/// <summary>
/// CurrencyCode değerini alır veya ayarlar.
/// </summary>
public string? CurrencyCode { get; set; }
    }
}
