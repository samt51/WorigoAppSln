using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    /// <summary>
    /// HotelConfiguration sınıfını temsil eder.
    /// </summary>
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            var hotel = new Hotel(1, "Tekstilkent", "Giyimkent", "Bağcılar", "02126733520", "tekstilkent@ramada.com", 4, 2);

            builder.HasData(hotel);
        }
    }
}
