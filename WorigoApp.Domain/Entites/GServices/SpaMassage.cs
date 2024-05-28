using WorigoApp.Domain.Common;

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
        public decimal Price { get; set; }
        public SpaMassage(int id, string name, string description, decimal price)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
    }
}
