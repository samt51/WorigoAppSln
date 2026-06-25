using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Restaurants.Queries.GetRestaurantReservations
{
/// <summary>
/// GetRestaurantReservationsQueryRequest sınıfını temsil eder.
/// </summary>
public class GetRestaurantReservationsQueryRequest : IRequest<ResponseDto<IList<RestaurantReservation>>>
    {
    }
}
