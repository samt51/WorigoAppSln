using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class Hotel : EntityBase
    {
        public Hotel()
        {
            
        }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int NumberOfStar { get; set; }
        public int Companyid { get; set; }
        public Company Company { get; set; }
        public IList<ImageCategory> ImageCategories { get; set; }
        public IList<Employee> Employees { get; set; }
        public IList<FoodMenuCategory> FoodMenuCategories { get; set; }
        public IList<Room> Rooms { get; set; }
        public IList<EmployeeType> Departments { get; set; }
        public Hotel(int id, string name, string location, string adress, string phoneNumber, string email, int numberOfStart, int companyId)
        {
            this.Id = id;
            this.Name = name;
            this.Location = location;
            this.Adress = adress;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.NumberOfStar = numberOfStart;
            this.Companyid = companyId;
        }
    }
}
