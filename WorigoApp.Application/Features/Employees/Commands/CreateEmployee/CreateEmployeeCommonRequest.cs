using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Employees.Dto;

namespace WorigoApp.Application.Features.Employees.Commands.CreateEmployee
{
/// <summary>
/// CreateEmployeeCommonRequest sınıfını temsil eder.
/// </summary>
public class CreateEmployeeCommonRequest : IRequest<ResponseDto<CreateEmployeeCommonResponse>>
    {
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; }
/// <summary>
/// Surname değerini alır veya ayarlar.
/// </summary>
public string Surname { get; set; }
/// <summary>
/// ImageUrl değerini alır veya ayarlar.
/// </summary>
public string ImageUrl { get; set; }
/// <summary>
/// EmployeeTypeId değerini alır veya ayarlar.
/// </summary>
public int EmployeeTypeId { get; set; }
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// employeeDetailRequest değerini alır veya ayarlar.
/// </summary>
public EmployeeDetailRequestDto employeeDetailRequest { get; set; }
    }
}
