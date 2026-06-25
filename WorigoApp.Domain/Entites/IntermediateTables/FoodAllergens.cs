using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.IntermediateTables
{
/// <summary>
/// FoodAllergens sınıfını temsil eder.
/// </summary>
public class FoodAllergens : IEntityBase
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
/// AllergenId değerini alır veya ayarlar.
/// </summary>
public int AllergenId { get; set; }
/// <summary>
/// Allergen değerini alır veya ayarlar.
/// </summary>
public Allergen Allergen { get; set; }
    }
}
