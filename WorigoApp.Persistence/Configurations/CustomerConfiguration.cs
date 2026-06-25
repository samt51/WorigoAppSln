using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations;

/// <summary>
/// CustomerConfiguration sınıfını temsil eder.
/// </summary>
public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.Property(x => x.IdentityDocumentType).HasMaxLength(30);
        builder.Property(x => x.IdentityDocumentNumber).HasMaxLength(80);
        builder.Property(x => x.Address).HasMaxLength(300);
    }
}
