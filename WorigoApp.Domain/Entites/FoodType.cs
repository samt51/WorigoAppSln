using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class FoodType : EntityBase
    {
        public FoodType()
        {

        }
        public string RoomFoodTypeValue { get; set; }
        //public RoomFoodTypeEnum RoomFoodTypeEnum { get; set; }
        public IList<Room> Rooms { get; set; }
        public FoodType(string roomFoodTypeValue)
        {
            this.RoomFoodTypeValue = roomFoodTypeValue;
        }
    }
}
