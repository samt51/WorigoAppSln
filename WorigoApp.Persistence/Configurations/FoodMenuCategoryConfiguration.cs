using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    /// <summary>
    /// FoodMenuCategoryConfiguration sınıfını temsil eder.
    /// </summary>
    public class FoodMenuCategoryConfiguration : IEntityTypeConfiguration<FoodMenuCategory>
    {
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<FoodMenuCategory> builder)
        {
            var foodMenuCategory = new FoodMenuCategory(1, "Pizza", 1);
            var foodMenuCategory2 = new FoodMenuCategory(2, "Hamburger", 1);

            builder.HasData(foodMenuCategory, foodMenuCategory2);

        }
    }
}
