using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Tasks.Commands.UpdateEmployeeTaskStatus
{
/// <summary>
/// UpdateEmployeeTaskStatusCommandResponse sınıfını temsil eder.
/// </summary>
public class UpdateEmployeeTaskStatusCommandResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public EmployeeTaskStatusEnum Status { get; set; }
/// <summary>
/// StartedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? StartedAt { get; set; }
/// <summary>
/// CompletedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? CompletedAt { get; set; }
    }
}
