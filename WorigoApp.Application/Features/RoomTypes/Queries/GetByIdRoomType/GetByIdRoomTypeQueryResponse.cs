using WorigoApp.Application.Features.Rooms.Queries.GetRooms;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.RoomTypes.Queries.GetByIdRoomType
{
    public class GetByIdRoomTypeQueryResponse
    {
        public int Id { get; set; }
        public RoomTypeEnum RoomTypeEnum { get; set; }
        public IList<GetRoomsQueryResponse> Rooms { get; set; }
    }
}
