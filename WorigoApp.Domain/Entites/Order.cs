using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class Order : EntityBase
    {
        public decimal TotalPrice { get; set; }
        public int RoomBasedTransactionId { get; set; }
        public RoomBasedTransaction RoomBasedTransaction { get; set; }
        public IList<OrderItem> OrderItems { get; set; }
        public IList<CommentAndRating> CommentAndRatings { get; set; }
    }
}
