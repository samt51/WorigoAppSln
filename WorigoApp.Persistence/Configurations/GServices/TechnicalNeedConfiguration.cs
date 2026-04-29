using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites.GServices;

namespace WorigoApp.Persistence.Configurations.GServices
{
    public class TechnicalNeedConfiguration : IEntityTypeConfiguration<TechnicalNeed>
    {
        public void Configure(EntityTypeBuilder<TechnicalNeed> builder)
        {
            var air = new TechnicalNeed(1, "Klima", "Klima ile ariza durumlari", "1.jpeg") { HotelId = 1, DepartmentId = 4, DisplayOrder = 1, EstimatedDurationMinutes = 60, SlaMinutes = 30 };
            var tv = new TechnicalNeed(2, "TV", "TV ile ariza durumlari", "1.jpeg") { HotelId = 1, DepartmentId = 4, DisplayOrder = 2, EstimatedDurationMinutes = 45, SlaMinutes = 30 };
            var minibar = new TechnicalNeed(3, "Minibar", "Minibar ile ariza durumlari", "1.jpeg") { HotelId = 1, DepartmentId = 4, DisplayOrder = 3, EstimatedDurationMinutes = 45, SlaMinutes = 30 };
            var kapi = new TechnicalNeed(4, "Kapi", "Kapi ile ariza durumlari", "1.jpeg") { HotelId = 1, DepartmentId = 4, DisplayOrder = 4, EstimatedDurationMinutes = 40, SlaMinutes = 30 };
            var elektrik = new TechnicalNeed(5, "Elektrik", "Elektrik ile ariza durumlari", "1.jpeg") { HotelId = 1, DepartmentId = 4, DisplayOrder = 5, EstimatedDurationMinutes = 30, SlaMinutes = 20 };
            var aydinlatma = new TechnicalNeed(6, "Aydinlatma", "Aydinlatma ile ariza durumlari", "1.jpeg") { HotelId = 1, DepartmentId = 4, DisplayOrder = 6, EstimatedDurationMinutes = 30, SlaMinutes = 20 };
            var dus = new TechnicalNeed(7, "Dus ve Tuvalet", "Dus ve tuvalet ile ariza durumlari", "1.jpeg") { HotelId = 1, DepartmentId = 4, DisplayOrder = 7, EstimatedDurationMinutes = 45, SlaMinutes = 30 };

            builder.HasData(air, tv, minibar, kapi, elektrik, aydinlatma, dus);
        }
    }
}
