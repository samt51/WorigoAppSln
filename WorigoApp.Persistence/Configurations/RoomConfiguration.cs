using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            var rooms = new System.Collections.Generic.List<Room>
            {
                new Room("101", 1, 1, 1, false, 1500, 1) { Id = 1, RoomNumber = "101", FloorNo = 1, Capacity = 2, Description = "Standart oda", CurrentStatus = "Available" },
                new Room("102", 1, 1, 1, false, 1500, 1) { Id = 2, RoomNumber = "102", FloorNo = 1, Capacity = 2, Description = "Standart oda", CurrentStatus = "Available" },
                new Room("103", 2, 1, 1, false, 2000, 1) { Id = 3, RoomNumber = "103", FloorNo = 1, Capacity = 2, Description = "Superior oda", CurrentStatus = "Available" },
                new Room("104", 2, 1, 1, false, 2000, 1) { Id = 4, RoomNumber = "104", FloorNo = 1, Capacity = 2, Description = "Superior oda", CurrentStatus = "Available" },
                new Room("105", 3, 1, 1, false, 2500, 1) { Id = 5, RoomNumber = "105", FloorNo = 1, Capacity = 3, Description = "Deluxe oda", CurrentStatus = "Available" },
                new Room("201", 1, 1, 1, false, 1500, 1) { Id = 6, RoomNumber = "201", FloorNo = 2, Capacity = 2, Description = "Standart oda", CurrentStatus = "Available" },
                new Room("202", 1, 1, 1, false, 1500, 1) { Id = 7, RoomNumber = "202", FloorNo = 2, Capacity = 2, Description = "Standart oda", CurrentStatus = "Available" },
                new Room("203", 4, 1, 1, false, 3000, 1) { Id = 8, RoomNumber = "203", FloorNo = 2, Capacity = 4, Description = "Aile odası", CurrentStatus = "Available" },
                new Room("204", 4, 1, 1, false, 3000, 1) { Id = 9, RoomNumber = "204", FloorNo = 2, Capacity = 4, Description = "Aile odası", CurrentStatus = "Available" },
                new Room("301", 5, 1, 1, false, 3500, 1) { Id = 10, RoomNumber = "301", FloorNo = 3, Capacity = 3, Description = "Junior Suit", CurrentStatus = "Available" },
                new Room("302", 6, 1, 1, false, 4000, 1) { Id = 11, RoomNumber = "302", FloorNo = 3, Capacity = 4, Description = "Suit", CurrentStatus = "Available" },
                new Room("303", 7, 1, 1, false, 8000, 1) { Id = 12, RoomNumber = "303", FloorNo = 3, Capacity = 6, Description = "Presidential Suit", CurrentStatus = "Available" }
            };

            builder.HasData(rooms);
        }
    }
}
