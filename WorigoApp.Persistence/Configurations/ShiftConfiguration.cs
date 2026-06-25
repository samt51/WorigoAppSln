using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    /// <summary>
    /// ShiftConfiguration sınıfını temsil eder.
    /// </summary>
    public class ShiftConfiguration : IEntityTypeConfiguration<Shift>
    {
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<Shift> builder)
        {
            var morningShift = new Shift
            {
                Id = 1,
                Name = "Sabah Vardiyasi",
                HotelId = 1,
                StartTime = new TimeSpan(8, 0, 0),
                EndTime = new TimeSpan(16, 0, 0),
                Description = "Sabah operasyon vardiyasi"
            };

            var eveningShift = new Shift
            {
                Id = 2,
                Name = "Aksam Vardiyasi",
                HotelId = 1,
                StartTime = new TimeSpan(16, 0, 0),
                EndTime = new TimeSpan(0, 0, 0),
                Description = "Aksam operasyon vardiyasi"
            };

            var nightShift = new Shift
            {
                Id = 3,
                Name = "Gece Vardiyasi",
                HotelId = 1,
                StartTime = new TimeSpan(0, 0, 0),
                EndTime = new TimeSpan(8, 0, 0),
                Description = "Gece operasyon vardiyasi",
                IsNightShift = true
            };

            builder.HasData(morningShift, eveningShift, nightShift);
        }
    }
}
