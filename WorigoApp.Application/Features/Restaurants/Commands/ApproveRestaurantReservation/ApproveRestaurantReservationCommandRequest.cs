using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Restaurants.Commands.ApproveRestaurantReservation
{
/// <summary>
/// ApproveRestaurantReservationCommandRequest sınıfını temsil eder.
/// </summary>
public class ApproveRestaurantReservationCommandRequest : IRequest<ResponseDto<ApproveRestaurantReservationResponse>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
    }
}
