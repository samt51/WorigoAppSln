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
                RoomTypeValue = "Standart"
            };
            RoomType roomType2 = new()
            {
                Id = 2,
                RoomTypeValue = "SingleRoom"
            };
            RoomType roomType3 = new()
            {
                Id = 3,
                RoomTypeValue = "DoubleRoom"
            };
            RoomType roomType4 = new()
            {
                Id = 4,
                RoomTypeValue = "TreeRoom"
            };
            RoomType roomType5 = new()
            {
                Id = 5,
                RoomTypeValue = "FourRoom"

            };
            RoomType roomType6 = new()
            {
                Id = 6,
                RoomTypeValue = "DubleksRoom"
            };
            RoomType roomType7 = new()
            {
                Id = 7,
                RoomTypeValue = "FamilyRoom"
            };
            RoomType roomType8 = new()
            {
                Id = 8,
                RoomTypeValue = "JuniorSuiter"
            };
            RoomType roomType9 = new()
            {
                Id = 9,
                RoomTypeValue = "KralDaire"
            };
            RoomType roomType10 = new()
            {
                Id = 10,
                RoomTypeValue = "SuitRoom"
            };
            RoomType roomType11 = new()
            {
                Id = 11,
                RoomTypeValue = "DisabledRoom"
            };
            builder.HasData(roomType, roomType2, roomType3, roomType4, roomType5, roomType6, roomType7, roomType8, roomType9, roomType10, roomType11);
        }
    }
}
