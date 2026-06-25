using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Restaurants.Commands.RejectRestaurantReservation
{
/// <summary>
/// RejectRestaurantReservationCommandRequest sınıfını temsil eder.
/// </summary>
public class RejectRestaurantReservationCommandRequest : IRequest<ResponseDto<RejectRestaurantReservationResponse>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
    }
}
