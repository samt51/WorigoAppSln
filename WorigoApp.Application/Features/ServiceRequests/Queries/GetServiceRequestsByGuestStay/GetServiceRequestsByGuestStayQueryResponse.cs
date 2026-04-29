using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequests.Queries.GetServiceRequestsByGuestStay
{
    public class GetServiceRequestsByGuestStayQueryResponse
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public ServicesEnum ServiceType { get; set; }
        public ServiceRequestStatusEnum Status { get; set; }
        public string LanguageCode { get; set; } = string.Empty;
        public DateTime RequestedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public int? AssignedEmployeeId { get; set; }
        public int? DepartmentId { get; set; }
    }
}
