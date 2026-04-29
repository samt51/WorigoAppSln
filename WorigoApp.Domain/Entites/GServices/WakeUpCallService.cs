using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.GServices
{
    /// <summary>
    /// Misafirin belirli bir saatte aranma veya uyandırılma talebini tanımlayan servis katalog kaydıdır.
    /// </summary>
    public class WakeUpCallService : EntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int? HotelId { get; set; }
        public int? DepartmentId { get; set; }
        public bool IsVisibleToGuest { get; set; } = true;
        public bool IsChargeable { get; set; }
        public decimal Price { get; set; }
        public int PriceStatusId { get; set; }
        public string CurrencyCode { get; set; } = "TRY";
        public bool RequiresAppointment { get; set; } = true;
    }
}
