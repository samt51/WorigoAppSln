using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// Restaurant sınıfını temsil eder.
/// </summary>
public class Restaurant : EntityBase
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// Hotel değerini alır veya ayarlar.
/// </summary>
public Hotel Hotel { get; set; } = null!;
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; } = string.Empty;
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string? Description { get; set; }
/// <summary>
/// ImageUrl değerini alır veya ayarlar.
/// </summary>
public string? ImageUrl { get; set; }
/// <summary>
/// Capacity değerini alır veya ayarlar.
/// </summary>
public int Capacity { get; set; }
/// <summary>
/// OpeningTime değerini alır veya ayarlar.
/// </summary>
public TimeSpan OpeningTime { get; set; }
/// <summary>
/// ClosingTime değerini alır veya ayarlar.
/// </summary>
public TimeSpan ClosingTime { get; set; }
/// <summary>
/// DisplayOrder değerini alır veya ayarlar.
/// </summary>
public int DisplayOrder { get; set; }
/// <summary>
/// Reservations değerini alır veya ayarlar.
/// </summary>
public IList<RestaurantReservation> Reservations { get; set; } = new List<RestaurantReservation>();
    }
}
