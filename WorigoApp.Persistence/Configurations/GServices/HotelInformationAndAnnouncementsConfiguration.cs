using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites.GServices;

namespace WorigoApp.Persistence.Configurations.GServices
{
    public class HotelInformationAndAnnouncementsConfiguration : IEntityTypeConfiguration<HotelInformationAndAnnouncements>
    {
        public void Configure(EntityTypeBuilder<HotelInformationAndAnnouncements> builder)
        {
          
        }
    }
}
