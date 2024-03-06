using MediatR;

namespace WorigoApp.Application.Features.ContentsOfFoods.Queries.GetAllContentsOfFood
{
    public class GetAllContentsOfFoodQueryRequest : IRequest<IList<GetAllContentsOfFoodQueryResponse>>
    {
        public int FoodId { get; }
        public GetAllContentsOfFoodQueryRequest(int foodid)
        {
            this.FoodId = foodid;
        }
    }
}
