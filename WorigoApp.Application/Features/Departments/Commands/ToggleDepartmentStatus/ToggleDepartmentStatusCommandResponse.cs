namespace WorigoApp.Application.Features.Departments.Commands.ToggleDepartmentStatus
{
/// <summary>
/// ToggleDepartmentStatusCommandResponse sınıfını temsil eder.
/// </summary>
public class ToggleDepartmentStatusCommandResponse
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
