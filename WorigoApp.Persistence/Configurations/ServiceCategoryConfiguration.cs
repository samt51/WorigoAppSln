using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Persistence.Configurations
{
    public class ServiceCategoryConfiguration : IEntityTypeConfiguration<ServiceCategory>
    {
        public void Configure(EntityTypeBuilder<ServiceCategory> builder)
        {
            builder.HasData(
                new ServiceCategory { Id = 1, HotelId = 1, Name = "Oda Hizmetleri", Description = "Oda ici misafir hizmetleri", IconKey = "housekeeping", DisplayOrder = 1, ShowOnHome = true, IsPopular = true, HomeDisplayOrder = 1, LegacyServiceType = ServicesEnum.HouseKeeping },
                new ServiceCategory { Id = 2, HotelId = 1, Name = "Teknik Servis", Description = "Ariza ve teknik destek talepleri", IconKey = "technical", DisplayOrder = 2, ShowOnHome = true, IsPopular = true, HomeDisplayOrder = 3, LegacyServiceType = ServicesEnum.TechnicalNeed },
                new ServiceCategory { Id = 3, HotelId = 1, Name = "On Buro", Description = "Resepsiyon, bellboy ve konaklama hizmetleri", IconKey = "reception", DisplayOrder = 3, ShowOnHome = true, IsPopular = true, HomeDisplayOrder = 4, LegacyServiceType = ServicesEnum.BellBoy },
                new ServiceCategory { Id = 4, HotelId = 1, Name = "Camasirhane", Description = "Utu, yikama ve kuru temizleme hizmetleri", IconKey = "laundry", DisplayOrder = 4, LegacyServiceType = ServicesEnum.DryCleaner },
                new ServiceCategory { Id = 5, HotelId = 1, Name = "Wellness ve Saglik", Description = "Spa, masaj, saglik ve guvenlik hizmetleri", IconKey = "spa", DisplayOrder = 5, LegacyServiceType = ServicesEnum.SpaMessage },
                new ServiceCategory { Id = 6, HotelId = 1, Name = "Ulasim", Description = "Transfer ve vale hizmetleri", IconKey = "transport", DisplayOrder = 6, LegacyServiceType = ServicesEnum.TravelOrTransportation },
                new ServiceCategory { Id = 7, HotelId = 1, Name = "Yiyecek Icecek", Description = "Menu ve minibar hizmetleri", IconKey = "food", DisplayOrder = 7, ShowOnHome = true, IsPopular = true, HomeDisplayOrder = 2, LegacyServiceType = ServicesEnum.Menu },
                new ServiceCategory { Id = 8, HotelId = 1, Name = "Bilgilendirme", Description = "Otel etkinlikleri ve duyurular", IconKey = "info", DisplayOrder = 8, LegacyServiceType = ServicesEnum.HealthAndSafety }
            );
        }
    }
}
