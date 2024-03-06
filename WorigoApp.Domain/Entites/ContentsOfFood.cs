using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class ContentsOfFood : EntityBase
    {
        public ContentsOfFood() { }
        public ContentsOfFood(string name, int foodid)
        {
            this.Name = name;
            this.FoodId = foodid;
        }
        public string Name { get; set;   }
        public int FoodId { get; set; }
        public Food Food { get; set; }
    }
}
