using WorigoApp.Application.Features.Departments.Queries.GetAllDepartment;

namespace WorigoApp.Application.Features.EmployeeTypes.Queries.GetByIdEmployeeType
{
/// <summary>
/// GetByIdEmployeeTypeQueryResponse sınıfını temsil eder.
/// </summary>
public class GetByIdEmployeeTypeQueryResponse
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
/// GetAllDepartmentQueryResponse değerini alır veya ayarlar.
/// </summary>
public GetAllDepartmentQueryResponse GetAllDepartmentQueryResponse { get; set; }
    }
}
