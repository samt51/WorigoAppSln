namespace WorigoApp.Application.Features.Employees.Queries.GetByIdEmployee
{
    public class GetByIdEmployeeResponse 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public int EmployeeTypeId { get; set; }
        public int HotelId { get; set; }
    }
}
