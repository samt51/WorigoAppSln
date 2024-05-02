using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites.GServices;

namespace WorigoApp.Persistence.Configurations.GServices
{
    public class TechnicalNeedConfiguration : IEntityTypeConfiguration<TechnicalNeed>
    {
        public void Configure(EntityTypeBuilder<TechnicalNeed> builder)
        {
            var air = new TechnicalNeed(1, "Klima", "Klima ile arıza durumları", "1.jpeg");
            var tv = new TechnicalNeed(2, "TV", "TV ile arıza durumları", "1.jpeg");
            var minibar = new TechnicalNeed(3, "Minibar", "Minibar ile arıza durumları", "1.jpeg");
            var kapi = new TechnicalNeed(4, "Kapı", "Kapı ile arıza durumları", "1.jpeg");
            var elektrik = new TechnicalNeed(5, "Elektrik", "Elektirk ile arıza durumları", "1.jpeg");
            var aydinlatma = new TechnicalNeed(6, "Aydınlatma", "Aydınlatma ile arıza durumları", "1.jpeg");
            var dus = new TechnicalNeed(7, "Duş Ve Tuvalet", "Aydınlatma ile arıza durumları", "1.jpeg");

            builder.HasData(air, tv, minibar, kapi, elektrik, aydinlatma, dus);
        }
    }
}
