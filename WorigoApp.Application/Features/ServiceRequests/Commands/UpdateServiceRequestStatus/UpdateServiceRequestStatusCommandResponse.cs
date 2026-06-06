using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequests.Commands.UpdateServiceRequestStatus
{
    public class UpdateServiceRequestStatusCommandResponse
    {
        public int Id { get; set; }
        public ServiceRequestStatusEnum Status { get; set; }
        public DateTime? AssignedAt { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public DateTime? ClosedAt { get; set; }
        public int HotelId { get; set; }
        public int? DepartmentId { get; set; }
        public int? AssignedEmployeeId { get; set; }
        public int GuestStayId { get; set; }
    }
}
