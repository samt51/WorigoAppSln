using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// Roles sınıfını temsil eder.
/// </summary>
public class Roles : EntityBase
    {
/// <summary>
/// Roles sınıfının yeni bir örneğini başlatır.
/// </summary>
public Roles()
        {

        }
/// <summary>
/// Roles sınıfının yeni bir örneğini başlatır.
/// </summary>
public Roles(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; }
/// <summary>
/// Users değerini alır veya ayarlar.
/// </summary>
public IList<Users> Users { get; set; }
    }
}
