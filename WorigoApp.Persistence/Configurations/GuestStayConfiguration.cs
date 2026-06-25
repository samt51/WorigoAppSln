using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    /// <summary>
    /// GuestStayConfiguration sınıfını temsil eder.
    /// </summary>
    public class GuestStayConfiguration : IEntityTypeConfiguration<GuestStay>
    {
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<GuestStay> builder)
        {
            builder.Property(x => x.TotalPrice).HasColumnType("decimal(18,2)");
            builder.Property(x => x.DepositAmount).HasColumnType("decimal(18,2)");
            builder.Property(x => x.SpecialRequests).HasMaxLength(1000);

            var data = new GuestStay(1, 1, 1, DateTime.Now, DateTime.Now.AddDays(2), Guid.NewGuid().ToString());

            builder.HasData(data);
        }
    }
}
