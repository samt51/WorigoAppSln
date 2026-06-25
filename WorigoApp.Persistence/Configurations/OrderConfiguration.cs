using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    /// <summary>
    /// OrderConfiguration sınıfını temsil eder.
    /// </summary>
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<Order> builder)
        {
            var order = new Order(1, 200, 1);

            builder.HasData(order);
        }
    }
}
