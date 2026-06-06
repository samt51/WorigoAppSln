using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            var room = new Room("101", 1, 1, 1, false, 1500, 1)
            {
                Id = 1,
                RoomNumber = "101",
                FloorNo = 1,
                Capacity = 2,
                Description = "Standart oda",
                CurrentStatus = "Available"
            };

            builder.HasData(room);
        }
    }
}
