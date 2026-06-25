using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Restaurants.Queries.GetMyRestaurantReservations
{
/// <summary>
/// GetMyRestaurantReservationsQueryRequest sınıfını temsil eder.
/// </summary>
public class GetMyRestaurantReservationsQueryRequest : IRequest<ResponseDto<IList<RestaurantReservation>>>
    {
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
    }
}
