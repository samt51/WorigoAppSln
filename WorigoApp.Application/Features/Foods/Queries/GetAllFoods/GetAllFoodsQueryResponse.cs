using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Foods.Queries.GetAllFoods
{
    public class GetAllFoodsQueryResponse
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int FoodMenuCategoryId { get; set; }
    }
}
