using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.IntermediateTables
{
    public class FoodContentsOfFood : IEntityBase
    {
        public int FoodId { get; set; }
        public Food Food { get; set; }
        public int ContentsOfFoodId { get; set; }
        public ContentsOfFood ContentsOfFood { get; set; }
        public bool IsActive { get; set; }
    }
}
