using System.Collections.Generic;

namespace WorigoApp.Application.Features.RoomTypes.Queries.GetRoomTypes
{
    public class GetRoomTypesQueryResponse
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Capacity { get; set; }
        public decimal BasePrice { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
        public int RoomCount { get; set; }
    }
}
