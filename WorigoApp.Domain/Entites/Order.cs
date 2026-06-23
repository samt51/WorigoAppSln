using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Misafirin ücretli veya paket dahil hizmet talepleri için oluşturulan sipariş üst bilgisidir.
    /// </summary>
    public class Order : EntityBase
    {
        public Order()
        {
        }

        public Order(int id, decimal totalPrice, int guestStayId)
        {
            Id = id;
            TotalPrice = totalPrice;
            GuestStayId = guestStayId;
        }

        public string OrderNumber { get; set; } = string.Empty;
        public decimal TotalPrice { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal ServiceChargeAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public string CurrencyCode { get; set; } = "TRY";
        public int PriceStatusId { get; set; }
        public OrderPaymentOptionEnum PaymentOption { get; set; } = OrderPaymentOptionEnum.RoomCharge;
        public OrderPaymentStatusEnum PaymentStatus { get; set; } = OrderPaymentStatusEnum.Pending;
        public OrderStatusEnum OrderStatus { get; set; } = OrderStatusEnum.Received;
        public DateTime? PreparationStartedAt { get; set; }
        public DateTime? ReadyAt { get; set; }
        public DateTime? DeliveryStartedAt { get; set; }
        public DateTime? DeliveredAt { get; set; }
        public bool IsPostedToRoom { get; set; }
        public DateTime? PostedToRoomAt { get; set; }
        public int? ServiceRequestId { get; set; }
        public ServiceRequest? ServiceRequest { get; set; }
        public int GuestStayId { get; set; }
        public GuestStay GuestStay { get; set; } = null!;
        public IList<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public IList<ServiceRequestRating> ServiceRequestRatings { get; set; } = new List<ServiceRequestRating>();
        public IList<Charge> Charges { get; set; } = new List<Charge>();
    }
}
