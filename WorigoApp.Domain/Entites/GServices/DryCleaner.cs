using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.GServices
{
    /// <summary>
    /// Kat Hizmetleri Teknik ihtiyaçlar gibi
    /// </summary>
    public class DryCleaner : EntityBase
    {
        public DryCleaner()
        {
            
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DryCleaner(int id, string name, string description, string imageUrl)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.ImageUrl = imageUrl;
        }
    }
}
