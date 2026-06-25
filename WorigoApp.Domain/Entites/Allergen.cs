using WorigoApp.Domain.Common;
using WorigoApp.Domain.Entites.IntermediateTables;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// Allergen sınıfını temsil eder.
/// </summary>
public class Allergen : EntityBase
    {
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; }         // Alerjen adı (örneğin, Gluten, Süt, Yumurta)
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string Description { get; set; }  // Alerjen hakkında açıklama
/// <summary>
/// FoodAllergens değerini alır veya ayarlar.
/// </summary>
public ICollection<FoodAllergens> FoodAllergens { get; set; }  // Bu alerjeni içeren yemekler
    }
}
