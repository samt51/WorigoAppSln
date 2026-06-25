using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Misafirin ücretli veya paket dahil hizmet talepleri için oluşturulan sipariş üst bilgisidir.
    /// </summary>
    public class Order : EntityBase
    {
/// <summary>
/// Order sınıfının yeni bir örneğini başlatır.
/// </summary>
public Order()
        {
        }
/// <summary>
/// Order sınıfının yeni bir örneğini başlatır.
/// </summary>
public Order(int id, decimal totalPrice, int guestStayId)
        {
            Id = id;
            TotalPrice = totalPrice;
            GuestStayId = guestStayId;
        }

/// <summary>
/// OrderNumber değerini alır veya ayarlar.
/// </summary>
public string OrderNumber { get; set; } = string.Empty;
/// <summary>
/// TotalPrice değerini alır veya ayarlar.
/// </summary>
public decimal TotalPrice { get; set; }
/// <summary>
/// DiscountAmount değerini alır veya ayarlar.
/// </summary>
public decimal DiscountAmount { get; set; }
/// <summary>
/// TaxAmount değerini alır veya ayarlar.
/// </summary>
public decimal TaxAmount { get; set; }
/// <summary>
/// ServiceChargeAmount değerini alır veya ayarlar.
/// </summary>
public decimal ServiceChargeAmount { get; set; }
/// <summary>
/// NetAmount değerini alır veya ayarlar.
/// </summary>
public decimal NetAmount { get; set; }
/// <summary>
/// PaidAmount değerini alır veya ayarlar.
/// </summary>
public decimal PaidAmount { get; set; }
/// <summary>
/// CurrencyCode değerini alır veya ayarlar.
/// </summary>
public string CurrencyCode { get; set; } = "TRY";
/// <summary>
/// PriceStatusId değerini alır veya ayarlar.
/// </summary>
public int PriceStatusId { get; set; }
/// <summary>
/// PaymentOption değerini alır veya ayarlar.
/// </summary>
public OrderPaymentOptionEnum PaymentOption { get; set; } = OrderPaymentOptionEnum.RoomCharge;
/// <summary>
/// PaymentStatus değerini alır veya ayarlar.
/// </summary>
public OrderPaymentStatusEnum PaymentStatus { get; set; } = OrderPaymentStatusEnum.Pending;
/// <summary>
/// OrderStatus değerini alır veya ayarlar.
/// </summary>
public OrderStatusEnum OrderStatus { get; set; } = OrderStatusEnum.Received;
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
/// <summary>
/// IsPostedToRoom değerini alır veya ayarlar.
/// </summary>
public bool IsPostedToRoom { get; set; }
/// <summary>
/// PostedToRoomAt değerini alır veya ayarlar.
/// </summary>
public DateTime? PostedToRoomAt { get; set; }
/// <summary>
/// ServiceRequestId değerini alır veya ayarlar.
/// </summary>
public int? ServiceRequestId { get; set; }
/// <summary>
/// ServiceRequest değerini alır veya ayarlar.
/// </summary>
public ServiceRequest? ServiceRequest { get; set; }
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
/// <summary>
/// GuestStay değerini alır veya ayarlar.
/// </summary>
public GuestStay GuestStay { get; set; } = null!;
/// <summary>
/// OrderItems değerini alır veya ayarlar.
/// </summary>
public IList<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
/// <summary>
/// ServiceRequestRatings değerini alır veya ayarlar.
/// </summary>
public IList<ServiceRequestRating> ServiceRequestRatings { get; set; } = new List<ServiceRequestRating>();
/// <summary>
/// Charges değerini alır veya ayarlar.
/// </summary>
public IList<Charge> Charges { get; set; } = new List<Charge>();
    }
}
