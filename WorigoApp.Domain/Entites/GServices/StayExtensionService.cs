using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.GServices
{
    /// <summary>
    /// Erken check-in ve geç check-out gibi konaklama uzatma taleplerini temsil eder.
    /// </summary>
    public class StayExtensionService : EntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int? HotelId { get; set; }
        public int? DepartmentId { get; set; }
        public decimal Price { get; set; }
        public int PriceStatusId { get; set; }
        public bool IsVisibleToGuest { get; set; } = true;
        public bool IsChargeable { get; set; } = true;
        public string CurrencyCode { get; set; } = "TRY";
        public bool RequiresAppointment { get; set; } = true;
    }
}
