using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    public class ContentsOfFoodConfiguration : IEntityTypeConfiguration<ContentsOfFood>
    {
        public void Configure(EntityTypeBuilder<ContentsOfFood> builder)
        {
            var data = new ContentsOfFood(1, "Siyah Zeytin");
            var data2 = new ContentsOfFood(2, "Mantar");
            var data3 = new ContentsOfFood(3, "Turşu");

            builder.HasData(data, data2, data3);
        }
    }
}
