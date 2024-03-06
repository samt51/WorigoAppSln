using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    public class FoodType : EntityBase
    {
        public FoodType()
        {
            
        }
        public RoomFoodTypeEnum RoomFoodTypeEnum { get; set; }
        public IList<Room> Rooms { get; set;}
        public FoodType(RoomFoodTypeEnum roomFoodTypeEnum)
        {
            this.RoomFoodTypeEnum = roomFoodTypeEnum;
        }
    }
}
