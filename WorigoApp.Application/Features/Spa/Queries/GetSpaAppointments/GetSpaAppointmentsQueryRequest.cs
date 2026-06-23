using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Spa.Queries.GetSpaAppointments
{
    public class GetSpaAppointmentsQueryRequest : IRequest<ResponseDto<IList<SpaAppointment>>>
    {
        public string SessionToken { get; set; } = string.Empty;
    }
}
