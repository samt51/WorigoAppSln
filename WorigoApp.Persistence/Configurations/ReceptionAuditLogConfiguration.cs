using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations;

/// <summary>
/// ReceptionAuditLogConfiguration sınıfını temsil eder.
/// </summary>
public class ReceptionAuditLogConfiguration : IEntityTypeConfiguration<ReceptionAuditLog>
{
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<ReceptionAuditLog> builder)
    {
        builder.Property(x => x.Action).HasMaxLength(80).IsRequired();
        builder.Property(x => x.EntityType).HasMaxLength(80).IsRequired();
        builder.Property(x => x.Details).HasMaxLength(2000);
        builder.HasIndex(x => new { x.HotelId, x.CreatedDate });
    }
}
