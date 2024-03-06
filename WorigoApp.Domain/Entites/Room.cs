using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class Room : EntityBase
    {
        public Room()
        {

        }
        public string Name { get; set; }
        public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
        public int RoomFoodTypeId { get; set; }
        public FoodType RoomFoodType { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public Room(string name, int roomTypeId, int roomFoodTypeId, int hotelid)
        {
            this.Name = name;
            this.RoomTypeId = roomTypeId;
            this.RoomFoodTypeId = roomFoodTypeId;
            this.HotelId = hotelid;
        }
    }
}
