using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.FoodMenuCategories.Queries.GetAllFoodMenuCategories
{
    public class GetAllFoodMenuCategoriesQueryRequest : IRequest<Response<IList<GetAllFoodMenuCategoriesQueryResponse>>>
    {
        public int HotelId { get; }
        public GetAllFoodMenuCategoriesQueryRequest(int hotelId)
        {
            this.HotelId = hotelId;
        }
    }
}
