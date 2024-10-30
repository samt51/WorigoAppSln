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
        /// <summary>
        /// menu ve bellboy gibi hizmetlerde adet olarak kullanılacak.
        /// </summary>
        public int Quantity { get; set; }
        public decimal? Price { get; set; }
        public int PriceStatusId { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public DateTime? AppointmentLastDate { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public CommentAndRating CommentAndRating { get; set; }
        public StatusTypeEnum StatusTypeEnum { get; set; }
        public string Text { get; set; }
        public IList<Image> Images { get; set; }
        public OrderItem(ServicesEnum serviceEnumId, int serviceItemId, int quantity, decimal? price, DateTime? appointmentDate,
            DateTime? appointmentLastDate, int orderId, StatusTypeEnum orderStatusEnum, string text)
        {
            this.ServicesEnumId = serviceEnumId;
            this.ServiceItemId = serviceItemId;
            this.Quantity = quantity;
            this.Price = price;
            this.AppointmentDate = appointmentDate;
            this.AppointmentLastDate = appointmentLastDate;
            this.OrderId = orderId;
            this.StatusTypeEnum = orderStatusEnum;
            this.Text = text;
        }
    }
}
