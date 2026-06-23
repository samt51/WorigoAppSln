using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Orders.Commands.UpdateFoodOrderStatus
{
    public class UpdateFoodOrderStatusResponse
    {
        public int OrderId { get; set; }
        public int GuestStayId { get; set; }
        public OrderStatusEnum OrderStatus { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
