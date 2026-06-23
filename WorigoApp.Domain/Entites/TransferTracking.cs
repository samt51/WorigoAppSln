using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class TransferTracking : EntityBase
    {
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;
        public int ServiceRequestId { get; set; }
        public ServiceRequest ServiceRequest { get; set; } = null!;
        public int GuestStayId { get; set; }
        public GuestStay GuestStay { get; set; } = null!;
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public string? DriverName { get; set; }
        public string? DriverPhone { get; set; }
        public string? VehiclePlate { get; set; }
        public string? VehicleModel { get; set; }
        public DateTime? EstimatedArrivalTime { get; set; }
        public string PickupLocation { get; set; } = string.Empty;
        public string DropoffLocation { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending"; // Pending, Assigned, InProgress, Completed, Cancelled
        public int? AssignedEmployeeId { get; set; }
        public Employee? AssignedEmployee { get; set; }
        public DateTime? AssignedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
    }
}
