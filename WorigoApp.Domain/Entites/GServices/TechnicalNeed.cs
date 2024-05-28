using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.GServices
{
    /// <summary>
    /// Teknik İhtiyaçlar
    /// </summary>
    public class TechnicalNeed : EntityBase
    {
        public TechnicalNeed()
        {

        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public TechnicalNeed(int id, string name, string description, string imageUrl)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.ImageUrl = imageUrl;
        }
    }
}
