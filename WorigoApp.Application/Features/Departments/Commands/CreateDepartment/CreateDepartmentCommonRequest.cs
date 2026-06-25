using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Departments.Commands.CreateDepartment
{
/// <summary>
/// CreateDepartmentCommonRequest sınıfını temsil eder.
/// </summary>
public class CreateDepartmentCommonRequest : IRequest<ResponseDto<CreateDepartmentCommonResponse>>
    {
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; }
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; }
/// <summary>
/// CreateDepartmentCommonRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateDepartmentCommonRequest(string name, int hotelid)
        {
            this.Name = name;
            this.HotelId = hotelid;
        }
    }
}
