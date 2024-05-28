using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.FoodMenuCategories.Queries.GetByIdFoodMenuCategory
{
    public class GetByIdFoodMenuCategoryQueryRequest : IRequest<Response<GetByIdFoodMenuCategoryQueryResponse>>
    {
        public GetByIdFoodMenuCategoryQueryRequest(int foodMenuCategoryId)
        {
            this.FoodMenuCategoryId = foodMenuCategoryId;
        }
        public int FoodMenuCategoryId { get; }
    }
}
