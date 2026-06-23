using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Spa.Commands.CancelSpaAppointment
{
    public class CancelSpaAppointmentCommandRequest : IRequest<ResponseDto<bool>>
    {
        public int Id { get; set; }
        public string SessionToken { get; set; } = string.Empty;
    }
}
