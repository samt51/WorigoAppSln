using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations;

/// <summary>
/// ReceptionCashShiftConfiguration sınıfını temsil eder.
/// </summary>
public class ReceptionCashShiftConfiguration : IEntityTypeConfiguration<ReceptionCashShift>
{
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<ReceptionCashShift> builder)
    {
        builder.Property(x => x.OpeningBalance).HasPrecision(18, 2);
        builder.Property(x => x.CashIncome).HasPrecision(18, 2);
        builder.Property(x => x.CashExpense).HasPrecision(18, 2);
        builder.Property(x => x.CountedBalance).HasPrecision(18, 2);
        builder.Property(x => x.Status).HasMaxLength(20);
        builder.Property(x => x.ClosingNote).HasMaxLength(1000);
        builder.HasIndex(x => new { x.HotelId, x.UserId, x.Status });
    }
}
