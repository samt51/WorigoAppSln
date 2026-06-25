namespace WorigoApp.Application.Features.Employees.Queries.GetAllEmployees
{
/// <summary>
/// GetAllEmployeesQueryResponse sınıfını temsil eder.
/// </summary>
public class GetAllEmployeesQueryResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
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
/// EmployeeTypeName değerini alır veya ayarlar.
/// </summary>
public string? EmployeeTypeName { get; set; }
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// IsAvailableForTask değerini alır veya ayarlar.
/// </summary>
public bool IsAvailableForTask { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public bool Status { get; set; }
/// <summary>
/// ActiveTaskCount değerini alır veya ayarlar.
/// </summary>
public int ActiveTaskCount { get; set; }
    }
}
