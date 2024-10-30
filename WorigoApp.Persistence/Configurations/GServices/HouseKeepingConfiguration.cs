using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites.GServices;

namespace WorigoApp.Persistence.Configurations.GServices
{
    public class HouseKeepingConfiguration : IEntityTypeConfiguration<HouseKeeping>
    {
        public void Configure(EntityTypeBuilder<HouseKeeping> builder)
        {
            var houseKeeping1 = new HouseKeeping(1, "Havlu değişimi veya eksiği", "1.jpeg");

            var houseKeeping2 = new HouseKeeping(2, "Oda Genel temizlik", "1.jpeg");

            var houseKeeping3 = new HouseKeeping(3, "Çarşaf veya yatak yüzü değişimi", "");

            builder.HasData(houseKeeping1, houseKeeping2, houseKeeping3);
        }
    }
}
