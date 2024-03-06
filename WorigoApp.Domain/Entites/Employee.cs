using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class Employee : EntityBase
    {
        public Employee()
        {

        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public int EmployeeTypeId { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public EmployeeDetail EmployeeDetail { get; set; }
        public Employee(int id, string name, string surName, string imageUrl, int employeeTypeId, int hotelId)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surName;
            this.ImageUrl = imageUrl;
            this.EmployeeTypeId = employeeTypeId;
            this.HotelId = hotelId;
        }
    }
}
