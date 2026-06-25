using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    /// <summary>
    /// FoodConfiguration sınıfını temsil eder.
    /// </summary>
    public class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<Food> builder)
        {
            var food = new Food(1, "New York", 150, 1, "New York Pizzası", 1);
            var food2 = new Food(2, "Kral Checkin", 200, 1, "Kral Checkin", 2);

            builder.HasData(food, food2);
        }
    }
}
