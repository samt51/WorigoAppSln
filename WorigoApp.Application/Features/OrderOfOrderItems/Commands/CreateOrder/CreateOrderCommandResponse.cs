namespace WorigoApp.Application.Features.OrderOfOrderItems.Commands.CreateOrder
{
    public class CreateOrderCommandResponse
    {
        public int Id { get; set; }
        public int GuestStayId { get; set; }
        public decimal TotalPrice { get; set; }
        public string CurrencyCode { get; set; } = "TRY";
        public string PaymentOption { get; set; } = string.Empty;
        public string PaymentStatus { get; set; } = string.Empty;
        public bool IsPostedToRoom { get; set; }
        public string? PaymentRedirectUrl { get; set; }
        public int OrderItemCount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
