using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class RoomBasedTransaction : EntityBase
    {
        public RoomBasedTransaction()
        {

        }
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string VerificationCode { get; set; }
        public IList<Order> Orders { get; set; }
        public IList<Customer> Customers { get; set; }
    }
}
