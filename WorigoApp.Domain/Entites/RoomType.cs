using WorigoApp.Domain.Common;
using System.Collections.Generic;

namespace WorigoApp.Domain.Entites
{
    public class RoomType : EntityBase
    {
        public RoomType()
        {
            Rooms = new List<Room>();
        }

        public int HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Capacity { get; set; } = 1;
        public decimal BasePrice { get; set; }
        public int DisplayOrder { get; set; }

        public IList<Room> Rooms { get; set; }
    }
}
