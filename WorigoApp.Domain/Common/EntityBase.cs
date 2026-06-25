namespace WorigoApp.Domain.Common
{
    /// <summary>
    /// EntityBase sınıfını temsil eder.
    /// </summary>
    public class EntityBase : IEntityBase
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// CreatedDate değerini alır veya ayarlar.
/// </summary>
public DateTime CreatedDate { get; set; } = DateTime.Now;
/// <summary>
/// ModifyDate değerini alır veya ayarlar.
/// </summary>
public DateTime ModifyDate { get; set; } = DateTime.Now;
/// <summary>
/// IsDeleted değerini alır veya ayarlar.
/// </summary>
public bool IsDeleted { get; set; } = false;
/// <summary>
/// IsActive değerini alır veya ayarlar.
/// </summary>
public bool IsActive { get; set; } = true;
    }
}
