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
    }
}
