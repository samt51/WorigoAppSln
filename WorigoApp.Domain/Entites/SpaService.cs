using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class SpaService : EntityBase
    {
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int DurationMinutes { get; set; }
        public decimal Price { get; set; }
        public string CurrencyCode { get; set; } = "TRY";
        public string? ImageUrl { get; set; }
    }
}
