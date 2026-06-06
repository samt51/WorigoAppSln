using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    public class GuestStayConfiguration : IEntityTypeConfiguration<GuestStay>
    {
        public void Configure(EntityTypeBuilder<GuestStay> builder)
        {
            builder.Property(x => x.TotalPrice).HasColumnType("decimal(18,2)");

            var data = new GuestStay(1, 1, 1, DateTime.Now, DateTime.Now.AddDays(2), Guid.NewGuid().ToString());

            builder.HasData(data);
        }
    }
}
