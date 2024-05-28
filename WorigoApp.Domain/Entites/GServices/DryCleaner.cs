using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.GServices
{
    /// <summary>
    /// Kat Hizmetleri Menu gibi
    /// 
    /// kategorize olacak ve ütü eklenecek
    /// </summary>
    public class DryCleaner : EntityBase
    {
        public DryCleaner()
        {

        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int? ParentId { get; set; }
        public decimal? Price { get; set; }
        public DryCleaner(int id, string name, string description, string imageUrl, int? parentId, decimal? price)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.ImageUrl = imageUrl;
            this.ParentId = parentId;
            this.Price = price;
        }
    }
}
