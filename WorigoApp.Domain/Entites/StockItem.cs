using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Otel stoklarinda takip edilen urun veya sarf malzemesini tutar.
    /// </summary>
    public class StockItem : EntityBase
    {
        /// <summary>
        /// Stok kaleminin ait oldugu otel.
        /// </summary>
        public int HotelId { get; set; }

        public Hotel Hotel { get; set; } = null!;

        /// <summary>
        /// Stok kaleminin en cok kullanildigi departman.
        /// </summary>
        public int? DepartmentId { get; set; }

        public Department? Department { get; set; }

        /// <summary>
        /// Stok kart kodu.
        /// </summary>
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// Urun veya malzeme adi.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Kullanilan birim. Ornek: Adet, Kg, Lt.
        /// </summary>
        public string Unit { get; set; } = "Adet";

        /// <summary>
        /// Anlik stok miktari.
        /// </summary>
        public decimal CurrentQuantity { get; set; }

        /// <summary>
        /// Kritik alt sinir.
        /// </summary>
        public decimal MinimumQuantity { get; set; }

        /// <summary>
        /// Son alis birim fiyati.
        /// </summary>
        public decimal? LastPurchasePrice { get; set; }

        /// <summary>
        /// Ortalama maliyet.
        /// </summary>
        public decimal AverageUnitCost { get; set; }

        /// <summary>
        /// Raporlarda kritik urun olarak izlenir.
        /// </summary>
        public bool IsCritical { get; set; }

        /// <summary>
        /// Aciklama veya teknik not.
        /// </summary>
        public string? Description { get; set; }

        public IList<StockMovement> StockMovements { get; set; } = new List<StockMovement>();
        public IList<StockRequestItem> StockRequestItems { get; set; } = new List<StockRequestItem>();
    }
}
