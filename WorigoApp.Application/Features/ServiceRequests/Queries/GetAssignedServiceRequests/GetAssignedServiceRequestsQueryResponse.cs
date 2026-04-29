using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequests.Queries.GetAssignedServiceRequests
{
    public class GetAssignedServiceRequestsQueryResponse
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public ServicesEnum ServiceType { get; set; }
        public ServiceRequestStatusEnum Status { get; set; }
        public int? RoomId { get; set; }
        public int? CustomerId { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime RequestedAt { get; set; }
        public DateTime? DueAt { get; set; }
    }
}
