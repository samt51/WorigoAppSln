using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Oteldeki oda bilgisini ve misafir operasyonu için gerekli alanları tutar.
    /// </summary>
    public class Room : EntityBase
    {
/// <summary>
/// Room sınıfının yeni bir örneğini başlatır.
/// </summary>
public Room()
        {
        }

/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Odanın fiziksel numarası.
        /// </summary>
        public string? RoomNumber { get; set; }

/// <summary>
/// RoomTypeId değerini alır veya ayarlar.
/// </summary>
public int RoomTypeId { get; set; }
/// <summary>
/// RoomType değerini alır veya ayarlar.
/// </summary>
public RoomType RoomType { get; set; } = null!;
/// <summary>
/// RoomFoodTypeId değerini alır veya ayarlar.
/// </summary>
public int RoomFoodTypeId { get; set; }
/// <summary>
/// RoomFoodType değerini alır veya ayarlar.
/// </summary>
public FoodType RoomFoodType { get; set; } = null!;
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// Hotel değerini alır veya ayarlar.
/// </summary>
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
/// <summary>
/// OperationalNote değerini alır veya ayarlar.
/// </summary>
public string? OperationalNote { get; set; }
/// <summary>
/// StatusUpdatedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? StatusUpdatedAt { get; set; }
/// <summary>
/// HousekeepingEmployeeId değerini alır veya ayarlar.
/// </summary>
public int? HousekeepingEmployeeId { get; set; }

/// <summary>
/// TargetTemperature değerini alır veya ayarlar.
/// </summary>
public double TargetTemperature { get; set; } = 22.0;
/// <summary>
/// LightsIntensity değerini alır veya ayarlar.
/// </summary>
public int LightsIntensity { get; set; } = 80;
/// <summary>
/// AreCurtainsOpen değerini alır veya ayarlar.
/// </summary>
public bool AreCurtainsOpen { get; set; } = true;

/// <summary>
/// Price değerini alır veya ayarlar.
/// </summary>
public decimal Price { get; set; }
/// <summary>
/// PriceStatusId değerini alır veya ayarlar.
/// </summary>
public int PriceStatusId { get; set; }

        /// <summary>
        /// Oda içi telefon numarası.
        /// </summary>
        public string? InternalPhoneNumber { get; set; }
/// <summary>
/// Room sınıfının yeni bir örneğini başlatır.
/// </summary>
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
