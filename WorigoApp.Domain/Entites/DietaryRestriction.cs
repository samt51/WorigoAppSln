using WorigoApp.Domain.Common;
using WorigoApp.Domain.Entites.IntermediateTables;

namespace WorigoApp.Domain.Entites
{
    public class DietaryRestriction:EntityBase
    {
        public string Name { get; set; }         // Diyet adı (örneğin, Vegan, Vejetaryen)
        public string Description { get; set; }  // Diyet hakkında açıklama
        public ICollection<FoodDietaryRestrictions> FoodDietaryRestrictions { get; set; }  // Bu diyete uygun yemekler
    }
}
