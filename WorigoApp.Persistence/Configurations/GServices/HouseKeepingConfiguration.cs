using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites.GServices;

namespace WorigoApp.Persistence.Configurations.GServices
{
    public class HouseKeepingConfiguration : IEntityTypeConfiguration<HouseKeeping>
    {
        public void Configure(EntityTypeBuilder<HouseKeeping> builder)
        {
            var houseKeeping1 = new HouseKeeping(1, "Havlu degisimi veya eksigi", "1.jpeg") { HotelId = 1, DepartmentId = 2, DisplayOrder = 1, EstimatedDurationMinutes = 15 };

            var houseKeeping2 = new HouseKeeping(2, "Oda genel temizlik", "1.jpeg") { HotelId = 1, DepartmentId = 2, DisplayOrder = 2, EstimatedDurationMinutes = 45 };

            var houseKeeping3 = new HouseKeeping(3, "Carsaf veya yatak yuzu degisimi", "") { HotelId = 1, DepartmentId = 2, DisplayOrder = 3, EstimatedDurationMinutes = 20 };

            builder.HasData(houseKeeping1, houseKeeping2, houseKeeping3);
        }
    }
}
