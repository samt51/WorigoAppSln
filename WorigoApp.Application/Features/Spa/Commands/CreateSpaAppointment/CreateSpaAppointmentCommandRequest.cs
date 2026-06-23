using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Spa.Commands.CreateSpaAppointment
{
    public class CreateSpaAppointmentCommandRequest : IRequest<ResponseDto<SpaAppointment>>
    {
        public string SessionToken { get; set; } = string.Empty;
        public string ServiceName { get; set; } = string.Empty;
        public string? TherapistName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string TimeSlot { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string? CurrencyCode { get; set; }
    }
}
