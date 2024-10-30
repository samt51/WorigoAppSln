using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    public class SystemParametreConfiguration : IEntityTypeConfiguration<SystemParametre>
    {
        public void Configure(EntityTypeBuilder<SystemParametre> builder)
        {
            var systemParametre = new SystemParametre(1, "PriceStatus");
            var systemParametre2 = new SystemParametre(2, "OrderStatus");
            var systemParametre3 = new SystemParametre(3, "RoomFoodTypeStatus");
            var systemParametre4 = new SystemParametre(4, "RoomTypeStatus");
            var systemParametre5 = new SystemParametre(5, "ServicesStatus");
            var systemParametre6 = new SystemParametre(6, "StatusType");
            var systemParametre7 = new SystemParametre(7, "TypesOfHealthAndSports");

            builder.HasData(systemParametre, systemParametre2, systemParametre3, systemParametre4, systemParametre5, systemParametre6, systemParametre7);
        }
    }
}
