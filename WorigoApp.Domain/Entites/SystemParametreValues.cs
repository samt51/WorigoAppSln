using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// SystemParametreValues sınıfını temsil eder.
/// </summary>
public class SystemParametreValues : IEntityBase
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// SystemParametreId değerini alır veya ayarlar.
/// </summary>
public int SystemParametreId { get; set; }
/// <summary>
/// SystemParametre değerini alır veya ayarlar.
/// </summary>
public SystemParametre SystemParametre { get; set; }
/// <summary>
/// ParametreValue değerini alır veya ayarlar.
/// </summary>
public string ParametreValue { get; set; }
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string Description { get; set; } = string.Empty;
/// <summary>
/// SystemParametreValueId değerini alır veya ayarlar.
/// </summary>
public int SystemParametreValueId { get; set; }
/// <summary>
/// IsDeleted değerini alır veya ayarlar.
/// </summary>
public bool IsDeleted { get; set; } = false;
/// <summary>
/// SystemParametreValues sınıfının yeni bir örneğini başlatır.
/// </summary>
public SystemParametreValues()
        {

        }
/// <summary>
/// SystemParametreValues sınıfının yeni bir örneğini başlatır.
/// </summary>
public SystemParametreValues(int id, int systemParametreId, string parametreValue, int systemParametreValueId, string description)
        {
            this.Id = id;
            this.SystemParametreId = systemParametreId;
            this.ParametreValue = parametreValue;
            this.Description = description;
            this.SystemParametreValueId = systemParametreValueId;
        }
/// <summary>
/// SystemParametreValues sınıfının yeni bir örneğini başlatır.
/// </summary>
public SystemParametreValues(int id, int systemParametreId, string parametreValue, int systemParametreValueId)
        {
            this.Id = id;
            this.SystemParametreId = systemParametreId;
            this.ParametreValue = parametreValue;
            this.SystemParametreValueId = systemParametreValueId;
        }
    }
}
