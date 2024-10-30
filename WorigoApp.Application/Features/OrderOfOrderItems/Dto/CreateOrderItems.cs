using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.OrderOfOrderItems.Dto
{
    public class CreateOrderItems
    {
        public ServicesEnum ServicesEnumId { get; set; }
        public int ServiceItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int PriceStatusId { get; set; }
        public DateTime? AppointmentDate { get; set; }
    }
}
