using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Foods.Queries.GetAllFoods
{
    public class GetAllFoodsQueryRequest : IRequest<ResponseDto<IList<GetAllFoodsQueryResponse>>>
    {
        public int FoodMenuCategoryId { get; }
        public GetAllFoodsQueryRequest(int foodMenuCategoryId)
        {
            this.FoodMenuCategoryId = foodMenuCategoryId;
        }
    }
}
