using WorigoApp.Application.Features.FoodTypes.Queries.GetAllFoodTypes;

namespace WorigoApp.Application.Features.Rooms.Queries.GetRooms
{
    public class GetRoomsQueryResponse
    {
        public string Name { get; set; }
        public int RoomTypeId { get; set; }
        public int RoomFoodTypeId { get; set; }
        public GetAllFoodTypesQueryResponse RoomFoodTypeResponse { get; set; }
        public int HotelId { get; set; }
    }
}
