using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Orders.Commands.UpdateFoodOrderStatus
{
/// <summary>
/// UpdateFoodOrderStatusResponse sınıfını temsil eder.
/// </summary>
public class UpdateFoodOrderStatusResponse
    {
/// <summary>
/// OrderId değerini alır veya ayarlar.
/// </summary>
public int OrderId { get; set; }
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
/// <summary>
/// OrderStatus değerini alır veya ayarlar.
/// </summary>
public OrderStatusEnum OrderStatus { get; set; }
/// <summary>
/// UpdatedAt değerini alır veya ayarlar.
/// </summary>
public DateTime UpdatedAt { get; set; }
    }
}
