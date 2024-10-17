using WorigoApp.Domain.Common;
using WorigoApp.Domain.Entites.IntermediateTables;

namespace WorigoApp.Domain.Entites
{
    public class ContentsOfFood : EntityBase
    {
        public ContentsOfFood() { }
        public ContentsOfFood(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public string Name { get; set; }
        public ICollection<FoodContentsOfFood> FoodContentsOfFoods { get; set; }
    }
}
