using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class Order : EntityBase
    {
        public Order()
        {

        }
        public Order(int id, decimal totalPrice, int roomBasedTransactionId)
        {
            this.Id = id;
            this.TotalPrice = totalPrice;
            this.RoomBasedTransactionId = roomBasedTransactionId;
        }
        public decimal TotalPrice { get; set; }
        public int PriceStatusId { get; set; }
        public int RoomBasedTransactionId { get; set; }
        public RoomBasedTransaction RoomBasedTransaction { get; set; }
        public IList<OrderItem> OrderItems { get; set; }
        public IList<CommentAndRating> CommentAndRatings { get; set; }
    }
}
