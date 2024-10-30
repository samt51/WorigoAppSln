using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites.GServices
{
    /// <summary>
    /// Spa Masaj
    /// </summary>
    public class SpaMassage : EntityBase
    {
        public SpaMassage()
        {

        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        /// <summary>
        /// spor türleri
        /// </summary>
        public TypesOfHealthAndSportsEnum TypesOfHealthAndSports { get; set; }
        public decimal Price { get; set; }
        public int PriceStatusId { get; set; }
        public SpaMassage(int id, string name, string description, decimal price, int priceStatusId)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.PriceStatusId = priceStatusId;
        }
    }
}
