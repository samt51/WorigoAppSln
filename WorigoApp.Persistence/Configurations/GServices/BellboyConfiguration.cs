using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites.GServices;

namespace WorigoApp.Persistence.Configurations.GServices
{
    public class BellboyConfiguration : IEntityTypeConfiguration<BellBoy>
    {
        public void Configure(EntityTypeBuilder<BellBoy> builder)
        {
            var bellboy1 = new BellBoy(1, "Bagaj Tasima", "1.jpeg")
            {
                HotelId = 1,
                DepartmentId = 1,
                Description = "Misafirin bagaj tasima talebi icin kullanilir.",
                EstimatedDurationMinutes = 10
            };

            builder.HasData(bellboy1);
        }

    }
}
