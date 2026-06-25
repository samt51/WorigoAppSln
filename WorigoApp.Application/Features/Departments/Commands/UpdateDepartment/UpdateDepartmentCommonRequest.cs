using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Departments.Commands.UpdateDepartment
{
/// <summary>
/// UpdateDepartmentCommonRequest sınıfını temsil eder.
/// </summary>
public class UpdateDepartmentCommonRequest : IRequest<ResponseDto<UpdateDepartmentCommonResponse>>
    {
/// <summary>
/// UpdateDepartmentCommonRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public UpdateDepartmentCommonRequest(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; }
    }
}
