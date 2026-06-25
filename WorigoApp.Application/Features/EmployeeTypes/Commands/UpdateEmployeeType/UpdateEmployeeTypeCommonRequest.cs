using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.EmployeeTypes.Commands.UpdateEmployeeType
{
/// <summary>
/// UpdateEmployeeTypeCommonRequest sınıfını temsil eder.
/// </summary>
public class UpdateEmployeeTypeCommonRequest : IRequest<ResponseDto<UpdateEmployeeTypeCommonResponse>>
    {
/// <summary>
/// UpdateEmployeeTypeCommonRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public UpdateEmployeeTypeCommonRequest(int id, string name)
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
