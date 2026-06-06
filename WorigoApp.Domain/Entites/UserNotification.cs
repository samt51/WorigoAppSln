using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class UserNotification : EntityBase
    {
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;

        public int? UserId { get; set; }
        public Users? User { get; set; }

        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }

        public int? ServiceRequestId { get; set; }
        public ServiceRequest? ServiceRequest { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string NotificationType { get; set; } = string.Empty;
        public bool IsRead { get; set; }
        public DateTime? ReadAt { get; set; }
    }
}
