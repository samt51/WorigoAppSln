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
                RoomTypeEnum = Domain.Enums.RoomTypeEnum.TreeRoom
            };
            RoomType roomType5 = new()
            {
                Id = 5,
                RoomTypeEnum = Domain.Enums.RoomTypeEnum.FourRoom

            };
            RoomType roomType6 = new()
            {
                Id = 6,
                RoomTypeEnum = Domain.Enums.RoomTypeEnum.DubleksRoom
            };
            RoomType roomType7 = new()
            {
                Id = 7,
                RoomTypeEnum = Domain.Enums.RoomTypeEnum.FamilyRoom
            };
            RoomType roomType8 = new()
            {
                Id = 8,
                RoomTypeEnum = Domain.Enums.RoomTypeEnum.JuniorSuiter
            };
            RoomType roomType9 = new()
            {
                Id = 9,
                RoomTypeEnum = Domain.Enums.RoomTypeEnum.KralDaire
            };
            RoomType roomType10 = new()
            {
                Id = 10,
                RoomTypeEnum = Domain.Enums.RoomTypeEnum.SuitRoom
            };
            RoomType roomType11 = new()
            {
                Id = 11,
                RoomTypeEnum = Domain.Enums.RoomTypeEnum.DisabledRoom
            };
            builder.HasData(roomType, roomType2, roomType3, roomType4, roomType5, roomType6, roomType7, roomType8, roomType9, roomType10, roomType11);
        }
    }
}
