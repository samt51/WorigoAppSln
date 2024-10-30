using WorigoApp.Domain.Common;
using WorigoApp.Domain.Entites.IntermediateTables;

namespace WorigoApp.Domain.Entites
{
    public class Allergen : EntityBase
    {
        public string Name { get; set; }         // Alerjen adı (örneğin, Gluten, Süt, Yumurta)
        public string Description { get; set; }  // Alerjen hakkında açıklama
        public ICollection<FoodAllergens> FoodAllergens { get; set; }  // Bu alerjeni içeren yemekler
    }
}
