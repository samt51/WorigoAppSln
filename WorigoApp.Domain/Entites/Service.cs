using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class Service : EntityBase
    {
        public Service()
        {
            
        }
        public Service(string name, string imageUrl, int hotelid)
        {
            Name = name;
            ImageUrl = imageUrl;
            HotelId = hotelid;
        }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public IList<ServiceOfFeature> ServiceOfFeatures { get; set; }
        public IList<ServiceOfValue> ServiceOfValues { get; set; }
    }
}
