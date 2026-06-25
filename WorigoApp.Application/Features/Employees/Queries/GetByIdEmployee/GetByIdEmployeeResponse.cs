namespace WorigoApp.Application.Features.Employees.Queries.GetByIdEmployee
{
/// <summary>
/// GetByIdEmployeeResponse sınıfını temsil eder.
/// </summary>
public class GetByIdEmployeeResponse 
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
    }
}
