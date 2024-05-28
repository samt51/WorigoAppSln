using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.GServices
{
    /// <summary>
    /// Kat Hizmetleri
    /// </summary>
    public class HouseKeeping : EntityBase
    {
        public HouseKeeping() { }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public HouseKeeping(int id, string name, string imageUrl)
        {
            this.Id = id;
            this.Name = name;
            this.ImageUrl = imageUrl;
        }
    }

}
