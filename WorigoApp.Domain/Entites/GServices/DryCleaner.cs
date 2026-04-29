using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.GServices
{
    /// <summary>
    /// Kuru temizleme ve benzeri ücretli servislerin katalog kaydıdır.
    /// </summary>
    public class DryCleaner : EntityBase
    {
        public DryCleaner()
        {
        }

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public int? HotelId { get; set; }
        public int? DepartmentId { get; set; }
        public int? ParentId { get; set; }
        public decimal? Price { get; set; }
        public int PriceStatusId { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsVisibleToGuest { get; set; } = true;
        public bool IsChargeable { get; set; } = true;
        public string CurrencyCode { get; set; } = "TRY";
        public int? EstimatedDurationMinutes { get; set; }

        public DryCleaner(int id, string name, string description, string imageUrl, int? parentId, decimal? price, int priceStatusId)
        {
            Id = id;
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
            ParentId = parentId;
            Price = price;
            PriceStatusId = priceStatusId;
        }
    }
}
