using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Restaurants.Commands.CancelRestaurantReservation
{
/// <summary>
/// CancelRestaurantReservationCommandRequest sınıfını temsil eder.
/// </summary>
public class CancelRestaurantReservationCommandRequest : IRequest<ResponseDto<bool>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
    }
}
