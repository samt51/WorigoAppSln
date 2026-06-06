using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    public class AnnouncementConfiguration : IEntityTypeConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
            builder.Property(x => x.Title)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasMaxLength(2000)
                .IsRequired();

            builder.Property(x => x.ImageUrl)
                .HasMaxLength(1000);

            builder.Property(x => x.Location)
                .HasMaxLength(250);

            builder.Property(x => x.AudienceType)
                .HasMaxLength(100);

            builder.HasOne(x => x.Hotel)
                .WithMany(x => x.Announcements)
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => new
                {
                    x.HotelId,
                    x.IsVisibleToGuest,
                    x.IsActive,
                    x.IsDeleted,
                    x.StartAt,
                    x.EndAt
                });
        }
    }
}
