using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.GServices
{
    /// <summary>
    /// Havaalanı transferi, şehir içi ulaşım ve benzeri ücretli veya rezervasyonlu ulaşım hizmetlerini tanımlar.
    /// </summary>
    public class TravelOrTransportation : EntityBase
    {
        public int? HotelId { get; set; }
        public int? DepartmentId { get; set; }

        /// <summary>
        /// Hizmetin görünen adını belirtir. Örn: Havaalanı transferi.
        /// </summary>
        public string TransportationType { get; set; } = string.Empty;

        /// <summary>
        /// Hizmet için hedef veya buluşma adresini belirtir.
        /// </summary>
        public string TransportationAddress { get; set; } = string.Empty;

        /// <summary>
        /// Araç veya ulaşım tipi bilgisidir. Örn: VIP Van, Sedan, Shuttle.
        /// </summary>
        public string TransportationVehicle { get; set; } = string.Empty;

        /// <summary>
        /// Tahmini planlanan rezervasyon tarihidir.
        /// </summary>
        public DateTime RequestDate { get; set; }

        /// <summary>
        /// Hizmetin liste fiyatını belirtir.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Fiyat statüsü veya fiyatlandırma tipi bilgisidir.
        /// </summary>
        public int PriceStatusId { get; set; }

        /// <summary>
        /// Hizmetin ücretli olup olmadığını belirtir.
        /// </summary>
        public bool IsChargeable { get; set; } = true;

        /// <summary>
        /// Misafire uygulamada görünüp görünmeyeceğini belirtir.
        /// </summary>
        public bool IsVisibleToGuest { get; set; } = true;

        /// <summary>
        /// Hizmetin para birimini belirtir.
        /// </summary>
        public string CurrencyCode { get; set; } = "TRY";

        /// <summary>
        /// Otel yönetimi için kısa açıklamayı tutar.
        /// </summary>
        public string? Description { get; set; }
    }
}
