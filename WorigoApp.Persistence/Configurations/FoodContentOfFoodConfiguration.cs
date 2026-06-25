using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites.IntermediateTables;

namespace WorigoApp.Persistence.Configurations
{
    /// <summary>
    /// FoodContentOfFoodConfiguration sınıfını temsil eder.
    /// </summary>
    public class FoodContentOfFoodConfiguration : IEntityTypeConfiguration<FoodContentsOfFood>
    {
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<FoodContentsOfFood> builder)
        {
            var data = new FoodContentsOfFood { ContentsOfFoodId = 1, FoodId = 1 };
            var data2 = new FoodContentsOfFood { ContentsOfFoodId = 2, FoodId = 1 };
            var data3 = new FoodContentsOfFood { ContentsOfFoodId = 3, FoodId = 1 };
            var data4 = new FoodContentsOfFood { ContentsOfFoodId = 3, FoodId = 2 };

            builder.HasData(data, data2, data3, data4);
        }
    }
}
