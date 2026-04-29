using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Persistence.Configurations
{
    public class ServiceDefinitionConfiguration : IEntityTypeConfiguration<ServiceDefinition>
    {
        public void Configure(EntityTypeBuilder<ServiceDefinition> builder)
        {
            builder.HasData(
                Definition(1, 2, ServicesEnum.TechnicalNeed, "Klima", "Klima ile ariza durumlari", "1.jpeg", 4, 1, 0, false, true, false, 60),
                Definition(2, 2, ServicesEnum.TechnicalNeed, "TV", "TV ile ariza durumlari", "1.jpeg", 4, 2, 0, false, true, false, 45),
                Definition(3, 2, ServicesEnum.TechnicalNeed, "Minibar", "Minibar ile ariza durumlari", "1.jpeg", 4, 3, 0, false, true, false, 45),
                Definition(4, 2, ServicesEnum.TechnicalNeed, "Kapi", "Kapi ile ariza durumlari", "1.jpeg", 4, 4, 0, false, true, false, 40),
                Definition(5, 2, ServicesEnum.TechnicalNeed, "Elektrik", "Elektrik ile ariza durumlari", "1.jpeg", 4, 5, 0, false, true, false, 30),
                Definition(6, 2, ServicesEnum.TechnicalNeed, "Aydinlatma", "Aydinlatma ile ariza durumlari", "1.jpeg", 4, 6, 0, false, true, false, 30),
                Definition(7, 2, ServicesEnum.TechnicalNeed, "Dus ve Tuvalet", "Dus ve tuvalet ile ariza durumlari", "1.jpeg", 4, 7, 0, false, true, false, 45),

                Definition(101, 1, ServicesEnum.HouseKeeping, "Havlu degisimi veya eksigi", null, "1.jpeg", 2, 1, 0, false, true, false, 15),
                Definition(102, 1, ServicesEnum.HouseKeeping, "Oda genel temizlik", null, "1.jpeg", 2, 2, 0, false, true, false, 45),
                Definition(103, 1, ServicesEnum.HouseKeeping, "Carsaf veya yatak yuzu degisimi", null, "", 2, 3, 0, false, true, false, 20),
                Definition(201, 3, ServicesEnum.BellBoy, "Bagaj Tasima", "Misafirin bagaj tasima talebi icin kullanilir.", "1.jpeg", 1, 1, 0, false, false, false, 10),

                Definition(301, 4, ServicesEnum.DryCleaner, "Utu", "Utu hizmeti", "1.jpeg", 2, 1, 0, false, false, false, null),
                Definition(302, 4, ServicesEnum.DryCleaner, "T-Shirt", "T-Shirt", "1.jpeg", 2, 2, 150, true, false, false, null),
                Definition(303, 4, ServicesEnum.DryCleaner, "Kaban-Mont", "Kaban-Mont", "1.jpeg", 2, 3, 250, true, false, false, null),
                Definition(304, 4, ServicesEnum.DryCleaner, "Kuru Temizleme", "Kuru temizleme", "1.jpeg", 2, 4, 0, false, false, false, null),
                Definition(305, 4, ServicesEnum.DryCleaner, "T-Shirt Kuru Temizleme", "T-Shirt", "1.jpeg", 2, 5, 150, true, false, false, null),
                Definition(306, 4, ServicesEnum.DryCleaner, "Kaban-Mont Kuru Temizleme", "Kaban-Mont", "1.jpeg", 2, 6, 200, true, false, false, null),
                Definition(307, 4, ServicesEnum.DryCleaner, "Pantolon", "Kot-kumas pantolonlar", "1.jpeg", 2, 7, 200, true, false, false, null),

                Definition(401, 5, ServicesEnum.SpaMessage, "Uzak Dogu", "Uzak Dogu masaji", null, 5, 1, 200, true, false, true, 60),
                Definition(402, 5, ServicesEnum.SpaMessage, "Tayland Masaji", "Tayland masaji", null, 5, 2, 200, true, false, true, 60),

                Definition(501, 6, ServicesEnum.TravelOrTransportation, "Transfer Talebi", "Misafir transfer veya ulasim talebi", null, 1, 1, 0, true, false, true, null),
                Definition(502, 6, ServicesEnum.ValetParking, "Vale Hizmeti", "Arac teslim alma veya hazirlama talebi", null, 1, 2, 0, true, false, false, null),
                Definition(601, 7, ServicesEnum.Minibar, "Minibar Talebi", "Minibar urun talebi", null, 2, 1, 0, true, false, false, null),
                Definition(602, 1, ServicesEnum.WakeUpCall, "Uyandirma Servisi", "Belirlenen saatte uyandirma talebi", null, 1, 4, 0, false, false, true, null),
                Definition(603, 3, ServicesEnum.StayExtension, "Konaklama Uzatma", "Gec cikis veya konaklama uzatma talebi", null, 1, 3, 0, true, false, true, null),
                Definition(604, 1, ServicesEnum.AmenityRequest, "Oda Malzemesi Talebi", "Ek yastik, bebek yatagi veya benzeri oda malzemeleri", null, 2, 4, 0, false, true, false, 20),
                Definition(605, 5, ServicesEnum.MedicalAssistance, "Medikal Yardim", "Saglik personeli veya doktor destegi", null, 5, 3, 0, false, true, true, null),
                Definition(606, 5, ServicesEnum.HealthAndSafety, "Saglik ve Guvenlik", "Saglik ve guvenlik bildirimi", null, 5, 4, 0, false, true, false, null),
                Definition(607, 8, ServicesEnum.HealthAndSafety, "Otel Bilgilendirme ve Duyuru", "Otel etkinlik ve duyuru bilgilendirmeleri", "1.jpeg", null, 1, 0, false, false, false, null),
                Definition(608, 7, ServicesEnum.Menu, "Menu Siparisi", "Yiyecek icecek menu siparisi", null, 3, 1, 0, true, false, false, 30)
            );
        }

        private static ServiceDefinition Definition(
            int id,
            int categoryId,
            ServicesEnum serviceType,
            string name,
            string? description,
            string? imageUrl,
            int? departmentId,
            int displayOrder,
            decimal price,
            bool isChargeable,
            bool supportsFreeText,
            bool requiresAppointment,
            int? estimatedDurationMinutes)
        {
            return new ServiceDefinition
            {
                Id = id,
                HotelId = 1,
                ServiceCategoryId = categoryId,
                ServiceType = serviceType,
                Name = name,
                Description = description,
                ImageUrl = imageUrl,
                DepartmentId = departmentId,
                DisplayOrder = displayOrder,
                Price = price,
                IsChargeable = isChargeable,
                SupportsFreeText = supportsFreeText,
                RequiresAppointment = requiresAppointment,
                EstimatedDurationMinutes = estimatedDurationMinutes,
                CurrencyCode = "TRY",
                IsVisibleToGuest = true
            };
        }
    }
}
