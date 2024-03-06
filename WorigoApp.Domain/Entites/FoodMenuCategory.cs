using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class FoodMenuCategory : EntityBase
    {
        public FoodMenuCategory()
        {
            
        }
        public FoodMenuCategory(string name, int hotelId)
        {
            this.Name = name;
            this.HotelId = hotelId;
        }
        public string Name { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public IList<Food> Foods { get; set; }
    }
}
