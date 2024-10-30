using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites.GServices;

namespace WorigoApp.Persistence.Configurations.GServices
{
    public class HotelInformationAndAnnouncementsConfiguration : IEntityTypeConfiguration<HotelInformationAndAnnouncements>
    {
        public void Configure(EntityTypeBuilder<HotelInformationAndAnnouncements> builder)
        {
            var hotelInformation = new HotelInformationAndAnnouncements(1, "Animasyon", "1.jpeg", "Sihirbaz Gösterisi", DateTime.Now);

            var hotelInformation2 = new HotelInformationAndAnnouncements(2, "Dans Gösterisi", "1.jpeg", "Animasyon", DateTime.Now);

            var hotelInformation3 = new HotelInformationAndAnnouncements(3, "Milli Maç", "1.jpeg", "Orta Salonda", DateTime.Now);

            var hotelInformation4 = new HotelInformationAndAnnouncements(4, "Dans Gösterisi", "1.jpeg", "Animasyon", DateTime.Now);

            builder.HasData(hotelInformation, hotelInformation2, hotelInformation3, hotelInformation4);
        }
    }
}
