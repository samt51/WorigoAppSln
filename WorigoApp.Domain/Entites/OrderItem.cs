using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Siparişe ait servis veya ürün satırlarını ve uygulanan fiyatlama bilgilerini tutar.
    /// </summary>
    public class OrderItem : EntityBase
    {
/// <summary>
/// OrderItem sınıfının yeni bir örneğini başlatır.
/// </summary>
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

/// <summary>
/// Price değerini alır veya ayarlar.
/// </summary>
public decimal? Price { get; set; }

        /// <summary>
        /// Sipariş anında uygulanan birim fiyattır.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// İndirim, vergi ve servis bedeli hariç satır toplamını belirtir.
        /// </summary>
        public decimal LineTotal { get; set; }

/// <summary>
/// DiscountAmount değerini alır veya ayarlar.
/// </summary>
public decimal DiscountAmount { get; set; }
/// <summary>
/// TaxAmount değerini alır veya ayarlar.
/// </summary>
public decimal TaxAmount { get; set; }
/// <summary>
/// ServiceChargeAmount değerini alır veya ayarlar.
/// </summary>
public decimal ServiceChargeAmount { get; set; }
/// <summary>
/// CurrencyCode değerini alır veya ayarlar.
/// </summary>
public string CurrencyCode { get; set; } = "TRY";

        /// <summary>
        /// İlgili kalemin konaklama paketine ücretsiz dahil edildiğini belirtir.
        /// </summary>
        public bool IsIncludedInPackage { get; set; }

        /// <summary>
        /// Sipariş satırında uygulanan otel servis kuralı kaydını tutar.
        /// </summary>
        public int? AppliedHotelServicePolicyId { get; set; }

/// <summary>
/// PaymentOption değerini alır veya ayarlar.
/// </summary>
public OrderPaymentOptionEnum PaymentOption { get; set; } = OrderPaymentOptionEnum.RoomCharge;
/// <summary>
/// PriceStatusId değerini alır veya ayarlar.
/// </summary>
public int PriceStatusId { get; set; }
/// <summary>
/// AppointmentDate değerini alır veya ayarlar.
/// </summary>
public DateTime? AppointmentDate { get; set; }
/// <summary>
/// AppointmentLastDate değerini alır veya ayarlar.
/// </summary>
public DateTime? AppointmentLastDate { get; set; }
/// <summary>
/// OrderId değerini alır veya ayarlar.
/// </summary>
public int OrderId { get; set; }
/// <summary>
/// Order değerini alır veya ayarlar.
/// </summary>
public Order Order { get; set; } = null!;
/// <summary>
/// ServiceRequestRating değerini alır veya ayarlar.
/// </summary>
public ServiceRequestRating? ServiceRequestRating { get; set; }
/// <summary>
/// StatusTypeEnum değerini alır veya ayarlar.
/// </summary>
public StatusTypeEnum StatusTypeEnum { get; set; }
/// <summary>
/// Text değerini alır veya ayarlar.
/// </summary>
public string Text { get; set; } = string.Empty;
/// <summary>
/// Images değerini alır veya ayarlar.
/// </summary>
public IList<Image> Images { get; set; } = new List<Image>();
/// <summary>
/// OrderItem sınıfının yeni bir örneğini başlatır.
/// </summary>
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
