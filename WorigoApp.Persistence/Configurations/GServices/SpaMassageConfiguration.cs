using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites.GServices;

namespace WorigoApp.Persistence.Configurations.GServices
{
    public class SpaMassageConfiguration : IEntityTypeConfiguration<SpaMassage>
    {
        public void Configure(EntityTypeBuilder<SpaMassage> builder)
        {
            var spa1 = new SpaMassage(1, "Uzak Dogu", "Uzak Dogu masaji", 200, 1)
            {
                HotelId = 1,
                DepartmentId = 5,
                EstimatedDurationMinutes = 60
            };
            var spa2 = new SpaMassage(2, "Tayland Masaji", "Tayland masaji", 200, 1)
            {
                HotelId = 1,
                DepartmentId = 5,
                EstimatedDurationMinutes = 60
            };

            builder.HasData(spa1, spa2);
        }
    }
}
