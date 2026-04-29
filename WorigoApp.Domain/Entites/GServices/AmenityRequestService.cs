using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.GServices
{
    /// <summary>
    /// Ek havlu, yastık, bebek yatağı ve benzeri oda ihtiyaçlarını temsil eden servis katalog kaydıdır.
    /// </summary>
    public class AmenityRequestService : EntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public int? HotelId { get; set; }
        public int? DepartmentId { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsVisibleToGuest { get; set; } = true;
        public bool SupportsFreeText { get; set; } = true;
        public bool IsChargeable { get; set; }
        public decimal Price { get; set; }
        public int PriceStatusId { get; set; }
        public string CurrencyCode { get; set; } = "TRY";
        public int? EstimatedDurationMinutes { get; set; }
    }
}
