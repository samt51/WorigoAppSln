namespace WorigoApp.Application.Features.Restaurants.Commands.RejectRestaurantReservation
{
/// <summary>
/// RejectRestaurantReservationResponse sınıfını temsil eder.
/// </summary>
public class RejectRestaurantReservationResponse
    {
/// <summary>
/// ReservationId değerini alır veya ayarlar.
/// </summary>
public int ReservationId { get; set; }
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
    }
}
