using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Departments.Commands.ToggleDepartmentStatus
{
/// <summary>
/// ToggleDepartmentStatusCommandRequest sınıfını temsil eder.
/// </summary>
public class ToggleDepartmentStatusCommandRequest : IRequest<ResponseDto<ToggleDepartmentStatusCommandResponse>>
    {
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int DepartmentId { get; set; }
/// <summary>
/// IsActive değerini alır veya ayarlar.
/// </summary>
public bool IsActive { get; set; }
    }
}
