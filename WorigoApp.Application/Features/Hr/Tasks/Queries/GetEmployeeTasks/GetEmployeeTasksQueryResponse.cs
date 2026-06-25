using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Tasks.Queries.GetEmployeeTasks
{
/// <summary>
/// GetEmployeeTasksQueryResponse sınıfını temsil eder.
/// </summary>
public class GetEmployeeTasksQueryResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Title değerini alır veya ayarlar.
/// </summary>
public string Title { get; set; } = string.Empty;
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string? Description { get; set; }
/// <summary>
/// Priority değerini alır veya ayarlar.
/// </summary>
public EmployeeTaskPriorityEnum Priority { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public EmployeeTaskStatusEnum Status { get; set; }
/// <summary>
/// DueAt değerini alır veya ayarlar.
/// </summary>
public DateTime? DueAt { get; set; }
    }
}
