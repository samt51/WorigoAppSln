using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Tasks.Commands.CreateEmployeeTask
{
/// <summary>
/// CreateEmployeeTaskCommandRequest sınıfını temsil eder.
/// </summary>
public class CreateEmployeeTaskCommandRequest : IRequest<ResponseDto<CreateEmployeeTaskCommandResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// AssignedEmployeeId değerini alır veya ayarlar.
/// </summary>
public int AssignedEmployeeId { get; set; }
/// <summary>
/// AssignedByEmployeeId değerini alır veya ayarlar.
/// </summary>
public int AssignedByEmployeeId { get; set; }
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int? DepartmentId { get; set; }
/// <summary>
/// RelatedServiceRequestId değerini alır veya ayarlar.
/// </summary>
public int? RelatedServiceRequestId { get; set; }
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
public EmployeeTaskPriorityEnum Priority { get; set; } = EmployeeTaskPriorityEnum.Normal;
/// <summary>
/// DueAt değerini alır veya ayarlar.
/// </summary>
public DateTime? DueAt { get; set; }
    }
}
