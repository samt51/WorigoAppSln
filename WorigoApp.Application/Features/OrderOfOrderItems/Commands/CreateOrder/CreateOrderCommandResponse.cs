namespace WorigoApp.Application.Features.OrderOfOrderItems.Commands.CreateOrder
{
/// <summary>
/// CreateOrderCommandResponse sınıfını temsil eder.
/// </summary>
public class CreateOrderCommandResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
/// <summary>
/// TotalPrice değerini alır veya ayarlar.
/// </summary>
public decimal TotalPrice { get; set; }
/// <summary>
/// CurrencyCode değerini alır veya ayarlar.
/// </summary>
public string CurrencyCode { get; set; } = "TRY";
/// <summary>
/// PaymentOption değerini alır veya ayarlar.
/// </summary>
public string PaymentOption { get; set; } = string.Empty;
/// <summary>
/// PaymentStatus değerini alır veya ayarlar.
/// </summary>
public string PaymentStatus { get; set; } = string.Empty;
/// <summary>
/// IsPostedToRoom değerini alır veya ayarlar.
/// </summary>
public bool IsPostedToRoom { get; set; }
/// <summary>
/// ServiceRequestId değerini alır veya ayarlar.
/// </summary>
public int? ServiceRequestId { get; set; }
/// <summary>
/// PaymentRedirectUrl değerini alır veya ayarlar.
/// </summary>
public string? PaymentRedirectUrl { get; set; }
/// <summary>
/// OrderItemCount değerini alır veya ayarlar.
/// </summary>
public int OrderItemCount { get; set; }
/// <summary>
/// CreatedAt değerini alır veya ayarlar.
/// </summary>
public DateTime CreatedAt { get; set; }
    }
}
