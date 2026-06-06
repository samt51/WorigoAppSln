using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequests.Commands.CreateServiceRequest
{
    public class CreateServiceRequestCommandResponse
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public int GuestStayId { get; set; }
        public ServiceRequestStatusEnum Status { get; set; }
        public DateTime RequestedAt { get; set; }
        public int? DepartmentId { get; set; }
        public int? AssignedEmployeeId { get; set; }
        public DateTime? DueAt { get; set; }
        public int? ManagerEmployeeId { get; set; }
        public IList<int> NotificationIds { get; set; } = new List<int>();
        public IList<int> ReceptionEmployeeIds { get; set; } = new List<int>();
    }
}
