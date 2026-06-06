namespace WorigoApp.Application.Features.Employees.Queries.GetAllEmployees
{
    public class GetAllEmployeesQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public int EmployeeTypeId { get; set; }
        public int HotelId { get; set; }
        public bool IsAvailableForTask { get; set; }
        public bool Status { get; set; }
        public int ActiveTaskCount { get; set; }
    }
}
