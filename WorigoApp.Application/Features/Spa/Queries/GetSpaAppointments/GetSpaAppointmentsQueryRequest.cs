using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Spa.Queries.GetSpaAppointments
{
/// <summary>
/// GetSpaAppointmentsQueryRequest sınıfını temsil eder.
/// </summary>
public class GetSpaAppointmentsQueryRequest : IRequest<ResponseDto<IList<SpaAppointment>>>
    {
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
    }
}
