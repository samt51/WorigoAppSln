using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Restaurants.Commands.CreateRestaurantReservation
{
/// <summary>
/// CreateRestaurantReservationCommandRequest sınıfını temsil eder.
/// </summary>
public class CreateRestaurantReservationCommandRequest : IRequest<ResponseDto<RestaurantReservation>>
    {
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
/// <summary>
/// RestaurantId değerini alır veya ayarlar.
/// </summary>
public int RestaurantId { get; set; }
/// <summary>
/// ReservationDate değerini alır veya ayarlar.
/// </summary>
public DateTime ReservationDate { get; set; }
/// <summary>
/// TimeSlot değerini alır veya ayarlar.
/// </summary>
public string TimeSlot { get; set; } = string.Empty;
/// <summary>
/// GuestCount değerini alır veya ayarlar.
/// </summary>
public int GuestCount { get; set; }
/// <summary>
/// Note değerini alır veya ayarlar.
/// </summary>
public string? Note { get; set; }
    }
}
