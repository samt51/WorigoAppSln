using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Rooms.Commands.CreateRoom
{
    public class UpdateRoomCommonRequest : IRequest<Response<UpdateRoomCommonResponse>>
    {
        public string Name { get; set; }
        public int RoomTypeId { get; set; }
        public RoomFoodTypeEnum RoomFoodTypeId { get; set; }
        public int HotelId { get; set; }
        public UpdateRoomCommonRequest(string name, int roomTypeId, RoomFoodTypeEnum roomFoodTypeId, int hotelId)
        {
            this.Name = name;
            this.RoomTypeId = roomTypeId;
            this.RoomFoodTypeId = roomFoodTypeId;
            this.HotelId = hotelId;
        }
    }
}
