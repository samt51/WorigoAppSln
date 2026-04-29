using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites.GServices;

namespace WorigoApp.Persistence.Configurations.GServices
{
    public class DryCleanerConfiguration : IEntityTypeConfiguration<DryCleaner>
    {
        public void Configure(EntityTypeBuilder<DryCleaner> builder)
        {
            var dryCleaner = new DryCleaner(1, "Utu", "Utu hizmeti", "1.jpeg", null, null, 1)
            {
                HotelId = 1,
                DepartmentId = 2,
                DisplayOrder = 1
            };

            var dryCleaner2 = new DryCleaner(2, "T-Shirt", "T-Shirt", "1.jpeg", 1, 150, 1)
            {
                HotelId = 1,
                DepartmentId = 2,
                DisplayOrder = 2
            };

            var dryCleaner3 = new DryCleaner(3, "Kaban-Mont", "Kaban-Mont", "1.jpeg", 1, 250, 1)
            {
                HotelId = 1,
                DepartmentId = 2,
                DisplayOrder = 3
            };

            var dryCleaner4 = new DryCleaner(4, "Kuru Temizleme", "Kuru temizleme", "1.jpeg", null, null, 1)
            {
                HotelId = 1,
                DepartmentId = 2,
                DisplayOrder = 4
            };

            var dryCleaner5 = new DryCleaner(5, "T-Shirt", "T-Shirt", "1.jpeg", 4, 150, 1)
            {
                HotelId = 1,
                DepartmentId = 2,
                DisplayOrder = 5
            };

            var dryCleaner6 = new DryCleaner(6, "Kaban-Mont", "Kaban-Mont", "1.jpeg", 4, 200, 1)
            {
                HotelId = 1,
                DepartmentId = 2,
                DisplayOrder = 6
            };

            var dryCleaner7 = new DryCleaner(7, "Pantolon", "Kot-kumas pantolonlar", "1.jpeg", 4, 200, 1)
            {
                HotelId = 1,
                DepartmentId = 2,
                DisplayOrder = 7
            };

            builder.HasData(dryCleaner, dryCleaner2, dryCleaner3, dryCleaner4, dryCleaner5, dryCleaner6, dryCleaner7);
        }
    }
}
