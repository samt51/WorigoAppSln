using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Restaurants.Queries.GetRestaurant
{
    public class GetRestaurantQueryRequest : IRequest<ResponseDto<Restaurant>>
    {
        public int RestaurantId { get; set; }
        public string SessionToken { get; set; } = string.Empty;
    }
}
