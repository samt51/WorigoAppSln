using WorigoApp.Domain.Common;
using WorigoApp.Domain.Entites.IntermediateTables;

namespace WorigoApp.Domain.Entites
{
    public class Food : EntityBase
    {
        public Food()
        {

        }
        public Food(int id, string name, decimal price, int priceStatusId, string description, int foodMenuCategoryId)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.PriceStatusId = priceStatusId;
            this.Description = description;
            this.FoodMenuCategoryId = foodMenuCategoryId;
        }
        public string Name { get; set; }
        public int PriceStatusId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int FoodMenuCategoryId { get; set; }
        public FoodMenuCategory FoodMenuCategory { get; set; }
        public ICollection<FoodContentsOfFood> FoodContentsOfFoods { get; set; }
    }
}
