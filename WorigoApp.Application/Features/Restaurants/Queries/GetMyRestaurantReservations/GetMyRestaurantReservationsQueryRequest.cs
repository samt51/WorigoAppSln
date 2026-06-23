using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Restaurants.Queries.GetMyRestaurantReservations
{
    public class GetMyRestaurantReservationsQueryRequest : IRequest<ResponseDto<IList<RestaurantReservation>>>
    {
        public string SessionToken { get; set; } = string.Empty;
    }
}
