using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class ImageCategory : EntityBase
    {
        public ImageCategory()
        {
                
        }
        public string Name { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public IList<Image> Images { get; set; }
        public ImageCategory(string name, int hotelId)
        {
            this.Name = name;
            this.HotelId = hotelId;
        }
    }
}
