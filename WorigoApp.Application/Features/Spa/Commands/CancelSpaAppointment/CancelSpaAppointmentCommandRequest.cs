using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Spa.Commands.CancelSpaAppointment
{
/// <summary>
/// CancelSpaAppointmentCommandRequest sınıfını temsil eder.
/// </summary>
public class CancelSpaAppointmentCommandRequest : IRequest<ResponseDto<bool>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
    }
}
