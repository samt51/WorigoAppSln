using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Transfers.Commands.AssignDriver
{
    public class AssignDriverCommandRequest : IRequest<ResponseDto<AssignDriverResponse>>
    {
        public int ServiceRequestId { get; set; }
        public string DriverName { get; set; } = string.Empty;
        public string DriverPhone { get; set; } = string.Empty;
        public string VehiclePlate { get; set; } = string.Empty;
        public string VehicleModel { get; set; } = string.Empty;
        public DateTime? EstimatedArrivalTime { get; set; }
    }
}
