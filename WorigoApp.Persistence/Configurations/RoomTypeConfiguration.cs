using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    public class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            RoomType roomType = new()
            {
                Id = 1,
                RoomTypeEnum = Domain.Enums.RoomTypeEnum.Standart
            };
            RoomType roomType2 = new()
            {
                Id = 2,
                RoomTypeEnum = Domain.Enums.RoomTypeEnum.SingleRoom
            };
            RoomType roomType3 = new()
            {
                Id = 3,
                RoomTypeEnum = Domain.Enums.RoomTypeEnum.DoubleRoom
            };

            RoomType roomType4 = new()
            {
                Id = 4,
                RoomTypeEnum = Domain.Enums.RoomTypeEnum.SuitRoom
            };

            builder.HasData(roomType, roomType2, roomType3, roomType4);
        }
    }
}
