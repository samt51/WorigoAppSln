namespace WorigoApp.Application.Features.Orders.Dtos
{
    public class OrderTrackingDto
    {
        public int OrderId { get; set; }
        public string OrderStatus { get; set; } = string.Empty;
        public DateTime ReceivedAt { get; set; }
        public DateTime? PreparationStartedAt { get; set; }
        public DateTime? ReadyAt { get; set; }
        public DateTime? DeliveryStartedAt { get; set; }
        public DateTime? DeliveredAt { get; set; }
    }
}
