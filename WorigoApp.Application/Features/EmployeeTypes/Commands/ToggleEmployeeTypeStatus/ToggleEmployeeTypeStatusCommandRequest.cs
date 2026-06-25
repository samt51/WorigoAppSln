using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.EmployeeTypes.Commands.ToggleEmployeeTypeStatus
{
/// <summary>
/// ToggleEmployeeTypeStatusCommandRequest sınıfını temsil eder.
/// </summary>
public class ToggleEmployeeTypeStatusCommandRequest : IRequest<ResponseDto<ToggleEmployeeTypeStatusCommandResponse>>
    {
/// <summary>
/// EmployeeTypeId değerini alır veya ayarlar.
/// </summary>
public int EmployeeTypeId { get; set; }
/// <summary>
/// IsActive değerini alır veya ayarlar.
/// </summary>
public bool IsActive { get; set; }
    }
}
