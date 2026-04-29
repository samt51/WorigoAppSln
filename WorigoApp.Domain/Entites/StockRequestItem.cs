using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Stok talebi altinda istenen urun satirlarini tutar.
    /// </summary>
    public class StockRequestItem : EntityBase
    {
        /// <summary>
        /// Bagli stok talebi.
        /// </summary>
        public int StockRequestId { get; set; }

        public StockRequest StockRequest { get; set; } = null!;

        /// <summary>
        /// Talep edilen stok kalemi.
        /// </summary>
        public int StockItemId { get; set; }

        public StockItem StockItem { get; set; } = null!;

        /// <summary>
        /// Ilk istenen miktar.
        /// </summary>
        public decimal RequestedQuantity { get; set; }

        /// <summary>
        /// Onaylanan miktar.
        /// </summary>
        public decimal? ApprovedQuantity { get; set; }

        /// <summary>
        /// Teslim edilen miktar.
        /// </summary>
        public decimal? FulfilledQuantity { get; set; }

        /// <summary>
        /// Birim fiyati.
        /// </summary>
        public decimal? UnitPrice { get; set; }

        /// <summary>
        /// Satir notu.
        /// </summary>
        public string? Note { get; set; }
    }
}
