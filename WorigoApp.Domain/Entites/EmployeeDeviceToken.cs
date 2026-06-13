using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class EmployeeDeviceToken : EntityBase
    {
        public int UserId { get; set; }
        public Users User { get; set; } = null!;

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;

        public string Token { get; set; } = string.Empty;
        public string Platform { get; set; } = "unknown";
        public string? DeviceId { get; set; }
        public DateTime LastSeenAt { get; set; } = DateTime.UtcNow;
    }
}
