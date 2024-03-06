using MediatR;

namespace WorigoApp.Application.Features.Foods.Queries.GetAllFoods
{
    public class GetAllFoodsQueryRequest : IRequest<IList<GetAllFoodsQueryResponse>>
    {
        public int FoodMenuCategoryId { get; }
        public GetAllFoodsQueryRequest(int foodMenuCategoryId)
        {
            this.FoodMenuCategoryId = foodMenuCategoryId;
        }
    }
}
