using MediatR;

namespace WorigoApp.Application.Features.FoodMenuCategories.Queries.GetAllFoodMenuCategories
{
    public class GetAllFoodMenuCategoriesQueryRequest : IRequest<IList<GetAllFoodMenuCategoriesQueryResponse>>
    {
        public int HotelId { get; }
        public GetAllFoodMenuCategoriesQueryRequest(int hotelId)
        {
            this.HotelId = hotelId;
        }
    }
}
