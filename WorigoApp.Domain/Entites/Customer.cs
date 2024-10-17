using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class Customer : EntityBase
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public bool Gender { get; set; }
        public int RoomBasedTransactionId { get; set; }
        public RoomBasedTransaction RoomBasedTransaction { get; set; }

    }
}
