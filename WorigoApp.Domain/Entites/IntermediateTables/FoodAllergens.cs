using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.IntermediateTables
{
    public class FoodAllergens : IEntityBase
    {
        public int FoodId { get; set; }
        public Food Food { get; set; }
        public int AllergenId { get; set; }
        public Allergen Allergen { get; set; }
    }
}
