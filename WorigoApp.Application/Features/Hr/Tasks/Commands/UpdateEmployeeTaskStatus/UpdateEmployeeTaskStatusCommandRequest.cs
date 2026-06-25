using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Tasks.Commands.UpdateEmployeeTaskStatus
{
/// <summary>
/// UpdateEmployeeTaskStatusCommandRequest sınıfını temsil eder.
/// </summary>
public class UpdateEmployeeTaskStatusCommandRequest : IRequest<ResponseDto<UpdateEmployeeTaskStatusCommandResponse>>
    {
/// <summary>
/// EmployeeTaskId değerini alır veya ayarlar.
/// </summary>
public int EmployeeTaskId { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public EmployeeTaskStatusEnum Status { get; set; }
/// <summary>
/// CompletionNote değerini alır veya ayarlar.
/// </summary>
public string? CompletionNote { get; set; }
    }
}
