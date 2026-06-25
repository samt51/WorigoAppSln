namespace WorigoApp.Application.Features.Rooms.Queries.GetRoomAvailabilityStatus
{
/// <summary>
/// RoomAvailabilityStatusResponse sınıfını temsil eder.
/// </summary>
public class RoomAvailabilityStatusResponse
    {
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public string Status { get; set; } = "Normal";
/// <summary>
/// UpdatedAt değerini alır veya ayarlar.
/// </summary>
public DateTime UpdatedAt { get; set; }
    }
}
