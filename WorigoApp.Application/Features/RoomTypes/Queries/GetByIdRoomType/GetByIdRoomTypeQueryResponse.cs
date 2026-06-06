using System.Collections.Generic;
using WorigoApp.Application.Features.Rooms.Queries.GetRooms;

namespace WorigoApp.Application.Features.RoomTypes.Queries.GetByIdRoomType
{
    public class GetByIdRoomTypeQueryResponse
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Capacity { get; set; }
        public decimal BasePrice { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
        public IList<GetRoomsQueryResponse> Rooms { get; set; } = new List<GetRoomsQueryResponse>();
    }
}
