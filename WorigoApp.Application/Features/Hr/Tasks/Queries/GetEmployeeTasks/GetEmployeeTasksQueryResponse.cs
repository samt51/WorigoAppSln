using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Tasks.Queries.GetEmployeeTasks
{
    public class GetEmployeeTasksQueryResponse
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public EmployeeTaskPriorityEnum Priority { get; set; }
        public EmployeeTaskStatusEnum Status { get; set; }
        public DateTime? DueAt { get; set; }
    }
}
