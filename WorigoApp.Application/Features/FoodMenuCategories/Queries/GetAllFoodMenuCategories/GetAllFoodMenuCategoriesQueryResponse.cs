using WorigoApp.Application.Features.Foods.Queries.GetAllFoods;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.FoodMenuCategories.Queries.GetAllFoodMenuCategories
{
    public class GetAllFoodMenuCategoriesQueryResponse
    {
        public string Name { get; set; }
        public int HotelId { get; set; }
        public IList<GetAllFoodsQueryResponse> Foods { get; set; }
    }
}
