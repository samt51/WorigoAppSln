using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class Restaurant : EntityBase
    {
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public int Capacity { get; set; }
        public TimeSpan OpeningTime { get; set; }
        public TimeSpan ClosingTime { get; set; }
        public int DisplayOrder { get; set; }
        public IList<RestaurantReservation> Reservations { get; set; } = new List<RestaurantReservation>();
    }
}
