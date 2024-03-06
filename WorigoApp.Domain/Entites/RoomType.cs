using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    public class RoomType : EntityBase
    {
        public RoomType()
        {
            
        }
        public RoomTypeEnum RoomTypeEnum { get; set; }
        public IList<Room> Rooms { get; set; }
        public RoomType(RoomTypeEnum roomTypeEnum)
        {
            this.RoomTypeEnum = roomTypeEnum;
        }
    }
}
