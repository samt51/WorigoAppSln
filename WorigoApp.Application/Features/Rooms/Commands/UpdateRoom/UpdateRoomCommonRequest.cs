using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Rooms.Commands.UpdateRoom
{
    public class UpdateRoomCommonRequest : IRequest<Response<UpdateRoomCommonResponse>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoomTypeId { get; set; }
        public RoomFoodTypeEnum RoomFoodTypeId { get; set; }
        public UpdateRoomCommonRequest(int id, string name, int roomTypeId, RoomFoodTypeEnum roomFoodTypeId)
        {
            this.Id = id;
            this.Name = name;
            this.RoomTypeId = roomTypeId;
            this.RoomFoodTypeId = roomFoodTypeId;
       
        }
    }
}
