using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Bir servisin belirli bir otelde ve belirli bir konaklama konseptinde görünür, dahil veya ücretli olup olmadığını yönetir.
    /// </summary>
    public class HotelServicePolicy : EntityBase
    {
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;

        /// <summary>
        /// Kuralın bağlı olduğu genel servis tipidir.
        /// </summary>
        public ServicesEnum ServiceType { get; set; }

        /// <summary>
        /// İlgili servis kataloğundaki özel kaydı belirtir. Boş ise tüm servis tipine uygulanır.
        /// </summary>
        public int? ServiceItemId { get; set; }

        public int? ServiceDefinitionId { get; set; }
        public ServiceDefinition? ServiceDefinition { get; set; }

        /// <summary>
        /// Kuralın geçerli olduğu konaklama konsepti.
        /// </summary>
        public AccommodationConceptTypeEnum AccommodationConceptType { get; set; }

        /// <summary>
        /// Servisin mobil uygulamada gösterilip gösterilmeyeceğini belirler.
        /// </summary>
        public bool IsVisible { get; set; } = true;

        /// <summary>
        /// Servisin paket dahilinde ücretsiz olup olmadığını belirtir.
        /// </summary>
        public bool IsIncludedInPackage { get; set; }

        /// <summary>
        /// Servisin ücretli kullanılacağını belirtir.
        /// </summary>
        public bool IsChargeable { get; set; }

        /// <summary>
        /// Ücretli kullanımda oda hesabına işlenmesine izin verilip verilmediğini belirtir.
        /// </summary>
        public bool AllowRoomCharge { get; set; } = true;

        /// <summary>
        /// Ücretli kullanımda online ödeme yapılmasına izin verilip verilmediğini belirtir.
        /// </summary>
        public bool AllowOnlinePayment { get; set; }

        /// <summary>
        /// Ücretli kullanımda fiziksel POS veya resepsiyon ödemesine izin verilip verilmediğini belirtir.
        /// </summary>
        public bool AllowOnSitePayment { get; set; } = true;

        /// <summary>
        /// Otelin bu konsept için özel fiyat tanımlaması yapmasını sağlar.
        /// </summary>
        public decimal? PriceOverride { get; set; }

        /// <summary>
        /// Kuralın para birimini belirtir.
        /// </summary>
        public string CurrencyCode { get; set; } = "TRY";

        /// <summary>
        /// Otel yönetiminin bu kural için yazdığı kısa açıklamayı tutar.
        /// </summary>
        public string? Description { get; set; }
    }
}
