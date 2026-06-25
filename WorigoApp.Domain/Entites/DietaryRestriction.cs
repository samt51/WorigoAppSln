using WorigoApp.Domain.Common;
using WorigoApp.Domain.Entites.IntermediateTables;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// DietaryRestriction sınıfını temsil eder.
/// </summary>
public class DietaryRestriction:EntityBase
    {
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; }         // Diyet adı (örneğin, Vegan, Vejetaryen)
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string Description { get; set; }  // Diyet hakkında açıklama
/// <summary>
/// FoodDietaryRestrictions değerini alır veya ayarlar.
/// </summary>
public ICollection<FoodDietaryRestrictions> FoodDietaryRestrictions { get; set; }  // Bu diyete uygun yemekler
    }
}
