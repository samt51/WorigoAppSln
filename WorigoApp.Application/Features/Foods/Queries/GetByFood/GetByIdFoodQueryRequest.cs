using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Foods.Queries.GetByFood
{
    public class GetByIdFoodQueryRequest : IRequest<Response<GetByIdFoodQueryResponse>>
    {
        public GetByIdFoodQueryRequest(int foodId)
        {
            this.FoodId = foodId;
        }
        public int FoodId { get; }
    }
}
