using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.GServices
{
    /// <summary>
    /// BellBoy
    /// </summary>
    public class BellBoy : EntityBase
    {
        public BellBoy()
        {

        }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public BellBoy(int id, string name, string imageUrl)
        {
            this.Name = name;
            this.Id = id;
            this.ImageUrl = imageUrl;
        }
    }
}
