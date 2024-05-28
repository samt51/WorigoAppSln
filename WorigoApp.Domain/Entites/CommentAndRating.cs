using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class CommentAndRating : EntityBase
    {
        public decimal SpeedPoint { get; set; }
        public decimal ProductPoint { get; set; }
        public decimal EmployeePoint { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int OrderItemId { get; set; }
        public OrderItem OrderItem { get; set; }
    }
}
