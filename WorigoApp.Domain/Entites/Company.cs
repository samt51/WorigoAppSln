using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// Company sınıfını temsil eder.
/// </summary>
public class Company : EntityBase
    {
/// <summary>
/// Company sınıfının yeni bir örneğini başlatır.
/// </summary>
public Company()
        {

        }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; }
/// <summary>
/// Hotels değerini alır veya ayarlar.
/// </summary>
public IList<Hotel> Hotels { get; set; }
/// <summary>
/// Company sınıfının yeni bir örneğini başlatır.
/// </summary>
public Company(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
