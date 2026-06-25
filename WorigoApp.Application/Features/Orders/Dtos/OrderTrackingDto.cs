namespace WorigoApp.Application.Features.Orders.Dtos
{
/// <summary>
/// OrderTrackingDto sınıfını temsil eder.
/// </summary>
public class OrderTrackingDto
    {
/// <summary>
/// OrderId değerini alır veya ayarlar.
/// </summary>
public int OrderId { get; set; }
/// <summary>
/// OrderStatus değerini alır veya ayarlar.
/// </summary>
public string OrderStatus { get; set; } = string.Empty;
/// <summary>
/// ReceivedAt değerini alır veya ayarlar.
/// </summary>
public DateTime ReceivedAt { get; set; }
/// <summary>
/// PreparationStartedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? PreparationStartedAt { get; set; }
/// <summary>
/// ReadyAt değerini alır veya ayarlar.
/// </summary>
public DateTime? ReadyAt { get; set; }
/// <summary>
/// DeliveryStartedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? DeliveryStartedAt { get; set; }
/// <summary>
/// DeliveredAt değerini alır veya ayarlar.
/// </summary>
public DateTime? DeliveredAt { get; set; }
    }
}
