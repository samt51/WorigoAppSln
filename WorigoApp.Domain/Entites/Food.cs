using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class Food : EntityBase
    {
        public Food()
        {
            
        }
        public Food(string name, decimal price, string description, int foodMenuCategoryId)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.FoodMenuCategoryId = foodMenuCategoryId;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int FoodMenuCategoryId { get; set; }
        public FoodMenuCategory FoodMenuCategory { get; set; }
        public IList<ContentsOfFood> ContentsOfFoods { get; set; }
    }
}
