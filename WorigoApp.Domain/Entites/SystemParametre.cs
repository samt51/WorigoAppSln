using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// SystemParametre sınıfını temsil eder.
/// </summary>
public class SystemParametre : IEntityBase
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// ParametreKey değerini alır veya ayarlar.
/// </summary>
public string ParametreKey { get; set; }
/// <summary>
/// IsDeleted değerini alır veya ayarlar.
/// </summary>
public bool IsDeleted { get; set; } = false;
/// <summary>
/// SystemParametreValues değerini alır veya ayarlar.
/// </summary>
public IList<SystemParametreValues> SystemParametreValues { get; set; }
/// <summary>
/// SystemParametre sınıfının yeni bir örneğini başlatır.
/// </summary>
public SystemParametre()
        {

        }
/// <summary>
/// SystemParametre sınıfının yeni bir örneğini başlatır.
/// </summary>
public SystemParametre(int id, string parametreKey)
        {
            this.Id = id;
            this.ParametreKey = parametreKey;
        }
    }
}
