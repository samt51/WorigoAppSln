using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequests.Commands.CreateServiceRequest
{
    public class CreateServiceRequestCommandResponse
    {
        public int Id { get; set; }
        public ServiceRequestStatusEnum Status { get; set; }
        public DateTime RequestedAt { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime? DueAt { get; set; }
    }
}
