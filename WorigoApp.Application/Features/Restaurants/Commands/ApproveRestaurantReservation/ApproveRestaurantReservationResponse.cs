namespace WorigoApp.Application.Features.Restaurants.Commands.ApproveRestaurantReservation
{
/// <summary>
/// ApproveRestaurantReservationResponse sınıfını temsil eder.
/// </summary>
public class ApproveRestaurantReservationResponse
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
