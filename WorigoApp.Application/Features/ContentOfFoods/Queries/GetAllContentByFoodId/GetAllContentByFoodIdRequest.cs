using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ContentOfFoods.Queries.GetAllContentByFoodId
{
    public class GetAllContentByFoodIdRequest : IRequest<Response<IList<GetAllContentByFoodIdResponse>>>
    {
        public int FoodId { get; }
        public GetAllContentByFoodIdRequest(int foodId)
        {
            this.FoodId = foodId;
        }
    }
}
