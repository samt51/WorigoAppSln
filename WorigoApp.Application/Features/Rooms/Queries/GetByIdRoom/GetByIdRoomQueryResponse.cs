using WorigoApp.Application.Features.FoodTypes.Queries.GetAllFoodTypes;

namespace WorigoApp.Application.Features.Rooms.Queries.GetByIdRoom
{
    public class GetByIdRoomQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoomTypeId { get; set; }
        public int RoomFoodTypeId { get; set; }
        public GetAllFoodTypesQueryResponse RoomFoodTypeResponse { get; set; }
        public int HotelId { get; set; }
    }
}
