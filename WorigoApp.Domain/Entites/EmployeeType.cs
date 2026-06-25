using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// EmployeeType sınıfını temsil eder.
/// </summary>
public class EmployeeType : EntityBase
    {
/// <summary>
/// EmployeeType sınıfının yeni bir örneğini başlatır.
/// </summary>
public EmployeeType()
        {
        }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; }
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int DepartmentId { get; set; }
/// <summary>
/// Department değerini alır veya ayarlar.
/// </summary>
public Department Department { get; set; }
/// <summary>
/// Employees değerini alır veya ayarlar.
/// </summary>
public IList<Employee> Employees { get; set; }
/// <summary>
/// EmployeeType sınıfının yeni bir örneğini başlatır.
/// </summary>
public EmployeeType(int id, string name, int departmentId)
        {
            this.Id = id;
            this.Name = name;
            this.DepartmentId = departmentId;
        }
    }
}
