namespace WorigoApp.Application.Features.Transfers.Commands.AssignDriver
{
    public class AssignDriverResponse
    {
        public int GuestStayId { get; set; }
        public string DriverName { get; set; } = string.Empty;
        public string VehiclePlate { get; set; } = string.Empty;
        public DateTime? EstimatedArrivalTime { get; set; }
    }
}
