using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites.GServices;

namespace WorigoApp.Persistence.Configurations.GServices
{
    public class BellboyConfiguration : IEntityTypeConfiguration<BellBoy>
    {
        public void Configure(EntityTypeBuilder<BellBoy> builder)
        {
            var bellboy1 = new BellBoy(1, "Bagaj Taşıma","1.jpeg");

            builder.HasData(bellboy1);
        }

    }
}
