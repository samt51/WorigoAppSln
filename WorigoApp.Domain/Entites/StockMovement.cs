using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Stok giris, cikis ve duzeltme hareketlerini kaydeder.
    /// </summary>
    public class StockMovement : EntityBase
    {
        /// <summary>
        /// Hareketin ait oldugu otel.
        /// </summary>
        public int HotelId { get; set; }

/// <summary>
/// Hotel değerini alır veya ayarlar.
/// </summary>
public Hotel Hotel { get; set; } = null!;

        /// <summary>
        /// Hareketin iliskili stok karti.
        /// </summary>
        public int StockItemId { get; set; }

/// <summary>
/// StockItem değerini alır veya ayarlar.
/// </summary>
public StockItem StockItem { get; set; } = null!;

        /// <summary>
        /// Hareketten etkilenen departman.
        /// </summary>
        public int? DepartmentId { get; set; }

/// <summary>
/// Department değerini alır veya ayarlar.
/// </summary>
public Department? Department { get; set; }

        /// <summary>
        /// Hareketi olusturan veya teslim alan personel.
        /// </summary>
        public int? EmployeeId { get; set; }

/// <summary>
/// Employee değerini alır veya ayarlar.
/// </summary>
public Employee? Employee { get; set; }

        /// <summary>
        /// Hareket tipi.
        /// </summary>
        public StockMovementTypeEnum MovementType { get; set; }

        /// <summary>
        /// Hareket miktari.
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Birim maliyet veya fiyat.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Toplam tutar.
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Hareket sebebi.
        /// </summary>
        public string? Reason { get; set; }

        /// <summary>
        /// Dis referans tipi. Ornek: StockRequest, Purchase, Manual.
        /// </summary>
        public string? ReferenceType { get; set; }

        /// <summary>
        /// Dis referans kaydinin id bilgisi.
        /// </summary>
        public int? ReferenceId { get; set; }

        /// <summary>
        /// Hareket zamani.
        /// </summary>
        public DateTime OccurredAt { get; set; } = DateTime.UtcNow;
    }
}
