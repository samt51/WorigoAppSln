using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Tasks.Commands.UpdateEmployeeTaskStatus
{
    public class UpdateEmployeeTaskStatusCommandResponse
    {
        public int Id { get; set; }
        public EmployeeTaskStatusEnum Status { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
    }
}
