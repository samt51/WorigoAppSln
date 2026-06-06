using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;
using System.Collections.Generic;

namespace WorigoApp.Persistence.Configurations
{
    public class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            builder.HasOne(x => x.Hotel)
                .WithMany()
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            var types = new List<RoomType>
            {
                new RoomType { Id = 1, HotelId = 1, Name = "Standard Room", Description = "Cozy standard room", Capacity = 2, BasePrice = 1500, DisplayOrder = 1, IsActive = true, IsDeleted = false },
                new RoomType { Id = 2, HotelId = 1, Name = "Superior Room", Description = "Spacious superior room", Capacity = 2, BasePrice = 2000, DisplayOrder = 2, IsActive = true, IsDeleted = false },
                new RoomType { Id = 3, HotelId = 1, Name = "Deluxe Room", Description = "Luxurious deluxe room", Capacity = 3, BasePrice = 2500, DisplayOrder = 3, IsActive = true, IsDeleted = false },
                new RoomType { Id = 4, HotelId = 1, Name = "Family Room", Description = "Perfect for families", Capacity = 4, BasePrice = 3000, DisplayOrder = 4, IsActive = true, IsDeleted = false },
                new RoomType { Id = 5, HotelId = 1, Name = "Junior Suite", Description = "Elegant junior suite", Capacity = 3, BasePrice = 3500, DisplayOrder = 5, IsActive = true, IsDeleted = false },
                new RoomType { Id = 6, HotelId = 1, Name = "Suite", Description = "Luxury suite", Capacity = 4, BasePrice = 4000, DisplayOrder = 6, IsActive = true, IsDeleted = false },
                new RoomType { Id = 7, HotelId = 1, Name = "Presidential Suite", Description = "The ultimate presidential suite", Capacity = 6, BasePrice = 8000, DisplayOrder = 7, IsActive = true, IsDeleted = false },
                new RoomType { Id = 8, HotelId = 1, Name = "Villa", Description = "Private villa experience", Capacity = 8, BasePrice = 15000, DisplayOrder = 8, IsActive = true, IsDeleted = false },
                new RoomType { Id = 9, HotelId = 1, Name = "Bungalow", Description = "Relaxing bungalow", Capacity = 4, BasePrice = 5000, DisplayOrder = 9, IsActive = true, IsDeleted = false },
                new RoomType { Id = 10, HotelId = 1, Name = "Accessible Room", Description = "Wheelchair accessible room", Capacity = 2, BasePrice = 1500, DisplayOrder = 10, IsActive = true, IsDeleted = false }
            };

            builder.HasData(types);
        }
    }
}
