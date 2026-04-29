using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Oteldeki oda bilgisini ve misafir operasyonu için gerekli alanları tutar.
    /// </summary>
    public class Room : EntityBase
    {
        public Room()
        {
        }

        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Odanın fiziksel numarası.
        /// </summary>
        public string? RoomNumber { get; set; }

        public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; } = null!;
        public int RoomFoodTypeId { get; set; }
        public FoodType RoomFoodType { get; set; } = null!;
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;

        /// <summary>
        /// Odanın bulunduğu kat numarası.
        /// </summary>
        public int? FloorNo { get; set; }

        /// <summary>
        /// Oda kapasitesi.
        /// </summary>
        public int Capacity { get; set; } = 1;

        /// <summary>
        /// Oda için kısa açıklama.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Oda şu anda dolu mu?
        /// </summary>
        public bool IsFull { get; set; }

        /// <summary>
        /// Odanın operasyonel durumu. Örn: Available, Occupied, Cleaning.
        /// </summary>
        public string CurrentStatus { get; set; } = "Available";

        public decimal Price { get; set; }
        public int PriceStatusId { get; set; }

        /// <summary>
        /// Oda içi telefon numarası.
        /// </summary>
        public string? InternalPhoneNumber { get; set; }

        public Room(string name, int roomTypeId, int roomFoodTypeId, int hotelid, bool isFull, decimal price, int priceStatusId)
        {
            Name = name;
            RoomTypeId = roomTypeId;
            RoomFoodTypeId = roomFoodTypeId;
            HotelId = hotelid;
            IsFull = isFull;
            Price = price;
            PriceStatusId = priceStatusId;
        }
    }
}
