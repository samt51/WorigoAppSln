namespace WorigoApp.Application.Features.EmployeeTypes.Commands.ToggleEmployeeTypeStatus
{
/// <summary>
/// ToggleEmployeeTypeStatusCommandResponse sınıfını temsil eder.
/// </summary>
public class ToggleEmployeeTypeStatusCommandResponse
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
