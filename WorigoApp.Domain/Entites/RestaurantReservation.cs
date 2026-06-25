using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// RestaurantReservation sınıfını temsil eder.
/// </summary>
public class RestaurantReservation : EntityBase
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
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
/// <summary>
/// GuestStay değerini alır veya ayarlar.
/// </summary>
public GuestStay GuestStay { get; set; } = null!;
/// <summary>
/// CustomerId değerini alır veya ayarlar.
/// </summary>
public int CustomerId { get; set; }
/// <summary>
/// Customer değerini alır veya ayarlar.
/// </summary>
public Customer Customer { get; set; } = null!;
/// <summary>
/// RestaurantId değerini alır veya ayarlar.
/// </summary>
public int RestaurantId { get; set; }
/// <summary>
/// Restaurant değerini alır veya ayarlar.
/// </summary>
public Restaurant Restaurant { get; set; } = null!;
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
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public string Status { get; set; } = "Pending"; // Pending, Approved, Rejected, Cancelled
/// <summary>
/// ApprovedByEmployeeId değerini alır veya ayarlar.
/// </summary>
public int? ApprovedByEmployeeId { get; set; }
/// <summary>
/// ApprovedByEmployee değerini alır veya ayarlar.
/// </summary>
public Employee? ApprovedByEmployee { get; set; }
/// <summary>
/// ApprovedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? ApprovedAt { get; set; }
/// <summary>
/// CancelledAt değerini alır veya ayarlar.
/// </summary>
public DateTime? CancelledAt { get; set; }
    }
}
