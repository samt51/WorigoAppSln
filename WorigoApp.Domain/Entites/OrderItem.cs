using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Siparişe ait servis veya ürün satırlarını ve uygulanan fiyatlama bilgilerini tutar.
    /// </summary>
    public class OrderItem : EntityBase
    {
        public OrderItem()
        {
        }

        /// <summary>
        /// Genel servis tipini belirtir.
        /// </summary>
        public ServicesEnum ServicesEnumId { get; set; }

        /// <summary>
        /// İlgili servis kataloğundaki özel kayıt bilgisidir.
        /// </summary>
        public int ServiceItemId { get; set; }

        /// <summary>
        /// Menü ve benzeri hizmetlerde adet olarak kullanılacak miktardır.
        /// </summary>
        public int Quantity { get; set; }

        public decimal? Price { get; set; }

        /// <summary>
        /// Sipariş anında uygulanan birim fiyattır.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// İndirim, vergi ve servis bedeli hariç satır toplamını belirtir.
        /// </summary>
        public decimal LineTotal { get; set; }

        public decimal DiscountAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal ServiceChargeAmount { get; set; }
        public string CurrencyCode { get; set; } = "TRY";

        /// <summary>
        /// İlgili kalemin konaklama paketine ücretsiz dahil edildiğini belirtir.
        /// </summary>
        public bool IsIncludedInPackage { get; set; }

        /// <summary>
        /// Sipariş satırında uygulanan otel servis kuralı kaydını tutar.
        /// </summary>
        public int? AppliedHotelServicePolicyId { get; set; }

        public OrderPaymentOptionEnum PaymentOption { get; set; } = OrderPaymentOptionEnum.RoomCharge;
        public int PriceStatusId { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public DateTime? AppointmentLastDate { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
        public CommentAndRating CommentAndRating { get; set; } = null!;
        public StatusTypeEnum StatusTypeEnum { get; set; }
        public string Text { get; set; } = string.Empty;
        public IList<Image> Images { get; set; } = new List<Image>();

        public OrderItem(ServicesEnum serviceEnumId, int serviceItemId, int quantity, decimal? price, DateTime? appointmentDate,
            DateTime? appointmentLastDate, int orderId, StatusTypeEnum orderStatusEnum, string text)
        {
            ServicesEnumId = serviceEnumId;
            ServiceItemId = serviceItemId;
            Quantity = quantity;
            Price = price;
            AppointmentDate = appointmentDate;
            AppointmentLastDate = appointmentLastDate;
            OrderId = orderId;
            StatusTypeEnum = orderStatusEnum;
            Text = text;
        }
    }
}
