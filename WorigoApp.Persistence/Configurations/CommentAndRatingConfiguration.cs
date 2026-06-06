using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    public class CommentAndRatingConfiguration : IEntityTypeConfiguration<CommentAndRating>
    {
        public void Configure(EntityTypeBuilder<CommentAndRating> builder)
        {
            builder.HasOne(x => x.Order)
                .WithMany(x => x.CommentAndRatings)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.OrderItem)
                .WithOne(x => x.CommentAndRating)
                .HasForeignKey<CommentAndRating>(x => x.OrderItemId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
