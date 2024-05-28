using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    public class OrderItem : EntityBase
    {
        public OrderItem()
        {
            
        }
        /// <summary>
        /// genel servis Id
        /// </summary>
        public ServicesEnum ServicesEnumId { get; set; }
        /// <summary>
        /// Servisin değer Id
        /// </summary>
        public int ServiceItemId { get; set; }
        public int Quantity { get; set; }
        public decimal? Price { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public CommentAndRating CommentAndRating { get; set; }
        public OrderStatusEnum OrderStatusEnum { get; set; }
        public OrderItem(ServicesEnum serviceEnumId, int serviceItemId, int quantity, decimal? price, DateTime? appointmentDate, int orderId, OrderStatusEnum orderStatusEnum)
        {
            this.ServicesEnumId = serviceEnumId;
            this.ServiceItemId = serviceItemId;
            this.Quantity = quantity;
            this.Price = price;
            this.AppointmentDate = appointmentDate;
            this.OrderId = orderId;
            this.OrderStatusEnum = orderStatusEnum;
        }
    }
}
