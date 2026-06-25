using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.IntermediateTables
{
/// <summary>
/// FoodDietaryRestrictions sınıfını temsil eder.
/// </summary>
public class FoodDietaryRestrictions : IEntityBase
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
/// DietaryRestrictionId değerini alır veya ayarlar.
/// </summary>
public int DietaryRestrictionId { get; set; }
/// <summary>
/// DietaryRestriction değerini alır veya ayarlar.
/// </summary>
public DietaryRestriction DietaryRestriction { get; set; }
    }
}
