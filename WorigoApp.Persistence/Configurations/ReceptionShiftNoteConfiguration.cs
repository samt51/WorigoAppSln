using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations;

/// <summary>
/// ReceptionShiftNoteConfiguration sınıfını temsil eder.
/// </summary>
public class ReceptionShiftNoteConfiguration : IEntityTypeConfiguration<ReceptionShiftNote>
{
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<ReceptionShiftNote> builder)
    {
        builder.Property(x => x.Content).HasMaxLength(2000).IsRequired();
        builder.Property(x => x.Priority).HasMaxLength(20).IsRequired();
        builder.HasIndex(x => new { x.HotelId, x.IsResolved, x.CreatedDate });
        builder.HasOne(x => x.Hotel).WithMany().HasForeignKey(x => x.HotelId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.CreatedByUser).WithMany().HasForeignKey(x => x.CreatedByUserId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.ResolvedByUser).WithMany().HasForeignKey(x => x.ResolvedByUserId).OnDelete(DeleteBehavior.Restrict);
    }
}
