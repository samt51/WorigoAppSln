using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.EmployeeTypes.Commands.CreateEmployeeType
{
/// <summary>
/// CreateEmployeeTypeCommonRequest sınıfını temsil eder.
/// </summary>
public class CreateEmployeeTypeCommonRequest : IRequest<ResponseDto<CreateEmployeeTypeCommonResponse>>
    {
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; }
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int DepartmentId { get; }
/// <summary>
/// CreateEmployeeTypeCommonRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateEmployeeTypeCommonRequest(string name, int departmentId)
        {
            this.Name = name;
            this.DepartmentId = departmentId;
        }
    }
}
