using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations;

/// <summary>
/// ReceptionCashTransactionConfiguration sınıfını temsil eder.
/// </summary>
public class ReceptionCashTransactionConfiguration : IEntityTypeConfiguration<ReceptionCashTransaction>
{
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<ReceptionCashTransaction> builder)
    {
        builder.Property(x => x.Amount).HasPrecision(18, 2);
        builder.Property(x => x.Type).HasMaxLength(20);
        builder.Property(x => x.PaymentMethod).HasMaxLength(30);
        builder.Property(x => x.Description).HasMaxLength(500);
        builder.HasOne(x => x.ReceptionCashShift).WithMany(x => x.Transactions).HasForeignKey(x => x.ReceptionCashShiftId).OnDelete(DeleteBehavior.Cascade);
    }
}
