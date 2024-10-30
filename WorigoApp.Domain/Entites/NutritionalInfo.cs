using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Besin Değerleri
    /// </summary>
    public class NutritionalInfo : EntityBase
    {
        /// <summary>
        /// Kalori miktarı
        /// </summary>
        public decimal Calories { get; set; }
        /// <summary>
        /// Protein miktarı (gram)
        /// </summary>
        public decimal Protein { get; set; }
        /// <summary>
        /// Yağ miktarı (gram)
        /// </summary>
        public decimal Fat { get; set; }
        /// <summary>
        /// Karbonhidrat miktarı (gram)
        /// </summary>
        public decimal Carbohydrates { get; set; }
        /// <summary>
        /// Şeker miktarı (gram)
        /// </summary>
        public decimal Sugar { get; set; }
        /// <summary>
        /// Lif miktarı (gram)
        /// </summary>
        public decimal Fiber { get; set; }
        public int FoodId { get; set; }
        public Food Food { get; set; }              // Bu besin bilgilerine sahip yemek
    }
}
