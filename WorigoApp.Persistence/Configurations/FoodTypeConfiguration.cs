using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    public class FoodTypeConfiguration : IEntityTypeConfiguration<FoodType>
    {
        public void Configure(EntityTypeBuilder<FoodType> builder)
        {
            FoodType foodType = new()
            {
                Id = 1,
                RoomFoodTypeEnum = Domain.Enums.RoomFoodTypeEnum.Breakfast
            };
            FoodType foodType2 = new()
            {
                Id = 2,
                RoomFoodTypeEnum = Domain.Enums.RoomFoodTypeEnum.HalfPension
            };
            FoodType foodType3 = new()
            {
                Id = 3,
                RoomFoodTypeEnum = Domain.Enums.RoomFoodTypeEnum.FullPension
            };
            FoodType foodTyp4 = new()
            {
                Id = 4,
                RoomFoodTypeEnum = Domain.Enums.RoomFoodTypeEnum.AllInclusive
            };
            FoodType foodType5 = new()
            {
                Id = 5,
                RoomFoodTypeEnum = Domain.Enums.RoomFoodTypeEnum.UltraAllInclusive
            };
            builder.HasData(foodType, foodType2, foodType3, foodTyp4, foodType5);
        }
    }
}
