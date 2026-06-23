using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    public class ServiceRequestRatingConfiguration : IEntityTypeConfiguration<ServiceRequestRating>
    {
        public void Configure(EntityTypeBuilder<ServiceRequestRating> builder)
        {
            builder.HasOne(x => x.ServiceRequest)
                .WithMany(x => x.Ratings)
                .HasForeignKey(x => x.ServiceRequestId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Customer)
                .WithMany()
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Order)
                .WithMany(x => x.ServiceRequestRatings)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.OrderItem)
                .WithOne(x => x.ServiceRequestRating)
                .HasForeignKey<ServiceRequestRating>(x => x.OrderItemId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Food)
                .WithMany(x => x.ServiceRequestRatings)
                .HasForeignKey(x => x.FoodId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
