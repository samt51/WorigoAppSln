using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites.GServices
{
    /// <summary>
    /// Spa ve masaj servislerinin katalog kaydıdır.
    /// </summary>
    public class SpaMassage : EntityBase
    {
        public SpaMassage()
        {
        }

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int? HotelId { get; set; }
        public int? DepartmentId { get; set; }
        public int? ParentId { get; set; }

        /// <summary>
        /// Spor veya sağlık hizmet tipi.
        /// </summary>
        public TypesOfHealthAndSportsEnum TypesOfHealthAndSports { get; set; }

        public decimal Price { get; set; }
        public int PriceStatusId { get; set; }
        public bool IsVisibleToGuest { get; set; } = true;
        /// <summary>
        /// Hizmetin ücretli olup olmadığını belirtir.
        /// </summary>
        public bool IsChargeable { get; set; } = true;
        public bool RequiresAppointment { get; set; } = true;
        public string CurrencyCode { get; set; } = "TRY";
        public int? EstimatedDurationMinutes { get; set; }

        public SpaMassage(int id, string name, string description, decimal price, int priceStatusId)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            PriceStatusId = priceStatusId;
        }
    }
}
