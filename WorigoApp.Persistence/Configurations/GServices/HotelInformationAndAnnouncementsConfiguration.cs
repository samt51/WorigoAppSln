using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites.GServices;

namespace WorigoApp.Persistence.Configurations.GServices
{
    public class HotelInformationAndAnnouncementsConfiguration : IEntityTypeConfiguration<HotelInformationAndAnnouncements>
    {
        public void Configure(EntityTypeBuilder<HotelInformationAndAnnouncements> builder)
        {
            var hotelInformation = new HotelInformationAndAnnouncements(1, "Animasyon", "1.jpeg", "Sihirbaz Gostersi", DateTime.Now)
            {
                HotelId = 1,
                Location = "Ana salon",
                IsVisibleToGuest = true
            };

            var hotelInformation2 = new HotelInformationAndAnnouncements(2, "Dans Gosterisi", "1.jpeg", "Animasyon", DateTime.Now)
            {
                HotelId = 1,
                Location = "Etkinlik alani",
                IsVisibleToGuest = true
            };

            var hotelInformation3 = new HotelInformationAndAnnouncements(3, "Milli Mac", "1.jpeg", "Orta salonda", DateTime.Now)
            {
                HotelId = 1,
                Location = "Orta salon",
                IsPinned = true,
                IsVisibleToGuest = true
            };

            var hotelInformation4 = new HotelInformationAndAnnouncements(4, "Dans Gosterisi", "1.jpeg", "Animasyon", DateTime.Now)
            {
                HotelId = 1,
                Location = "Animasyon alani",
                IsVisibleToGuest = false
            };

            builder.HasData(hotelInformation, hotelInformation2, hotelInformation3, hotelInformation4);
        }
    }
}
