using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.IntermediateTables
{
/// <summary>
/// FoodContentsOfFood sınıfını temsil eder.
/// </summary>
public class FoodContentsOfFood : IEntityBase
    {
/// <summary>
/// FoodId değerini alır veya ayarlar.
/// </summary>
public int FoodId { get; set; }
/// <summary>
/// Food değerini alır veya ayarlar.
/// </summary>
public Food Food { get; set; }
/// <summary>
/// ContentsOfFoodId değerini alır veya ayarlar.
/// </summary>
public int ContentsOfFoodId { get; set; }
/// <summary>
/// ContentsOfFood değerini alır veya ayarlar.
/// </summary>
public ContentsOfFood ContentsOfFood { get; set; }
/// <summary>
/// IsActive değerini alır veya ayarlar.
/// </summary>
public bool IsActive { get; set; }
    }
}
