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

            var cleaner = new DryCleaner(1, "Yıkama", "Elbiseleriniz yıkamak için talep oluşturunuz.", "1.jpeg", null, null, 0);
           

            var dryCleaner = new DryCleaner(1, "Ütü", "Ütü Hizmeti", "1.jpeg", null, null, 1);

            var dryCleaner2 = new DryCleaner(2, "T-shirt", "T-shirt", "1.jpeg", 1, 150, 1);

            var dryCleaner3 = new DryCleaner(3, "Kaban-Mont", "Kaban-Mont", "1.jpeg", 1, 250, 1);

            var dryCleaner4 = new DryCleaner(4, "Kuru Temizleme", "Kuru Temizleme", "1jpeg", null, null, 1);

            var dryCleaner5 = new DryCleaner(5, "T-shirt", "T-shirt", "1.jpeg", 4, 150, 1);

            var dryCleaner6 = new DryCleaner(6, "Kaban-Mont", "Kaban-Mont", "1.jpeg", 4, 200, 1);

            var dryCleaner7 = new DryCleaner(7, "Pantolon", "Kot-Kumaş pantolonlar", "1.jpeg", 4, 200, 1);

            builder.HasData(dryCleaner, dryCleaner2, dryCleaner3, dryCleaner4, dryCleaner5, dryCleaner6, dryCleaner7);
        }
    }
}
