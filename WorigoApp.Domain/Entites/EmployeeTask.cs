using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Personel icin yonetici veya departman tarafindan acilan ic gorev kaydini tutar.
    /// </summary>
    public class EmployeeTask : EntityBase
    {
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;
        public int AssignedEmployeeId { get; set; }
        public Employee AssignedEmployee { get; set; } = null!;
        public int AssignedByEmployeeId { get; set; }
        public Employee AssignedByEmployee { get; set; } = null!;
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        public int? RelatedServiceRequestId { get; set; }
        public ServiceRequest? RelatedServiceRequest { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public EmployeeTaskPriorityEnum Priority { get; set; } = EmployeeTaskPriorityEnum.Normal;
        public EmployeeTaskStatusEnum Status { get; set; } = EmployeeTaskStatusEnum.Open;
        public DateTime? DueAt { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public string? CompletionNote { get; set; }
    }
}
