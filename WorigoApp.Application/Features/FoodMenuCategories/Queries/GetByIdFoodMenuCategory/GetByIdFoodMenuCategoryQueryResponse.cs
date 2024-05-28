using WorigoApp.Application.Features.Foods.Queries.GetAllFoods;

namespace WorigoApp.Application.Features.FoodMenuCategories.Queries.GetByIdFoodMenuCategory
{
    public class GetByIdFoodMenuCategoryQueryResponse
    {
        public string Name { get; set; }
        public int HotelId { get; set; }
        public IList<GetAllFoodsQueryResponse> Foods { get; set; }
    }
}
