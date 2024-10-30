using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.IntermediateTables
{
    public class FoodDietaryRestrictions : IEntityBase
    {
        public int FoodId { get; set; }
        public Food Food { get; set; }
        public int DietaryRestrictionId { get; set; }
        public DietaryRestriction DietaryRestriction { get; set; }
    }
}
