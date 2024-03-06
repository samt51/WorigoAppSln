using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class Department : EntityBase
    {
        public Department() { }
        public Department(int id, string name, string imageUrl, int hotelid)
        {
            this.Id = id;
            this.Name = name;
            this.ImageUrl = imageUrl;
            this.HotelId = hotelid;
        }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public IList<EmployeeType> EmployeeTypes { get; set; }

    }
}
