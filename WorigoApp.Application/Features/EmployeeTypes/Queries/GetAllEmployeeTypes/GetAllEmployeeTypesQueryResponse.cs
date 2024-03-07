using WorigoApp.Application.Features.Departments.Queries.GetAllDepartment;

namespace WorigoApp.Application.Features.EmployeeTypes.Queries.GetAllEmployeeTypes
{
    public class GetAllEmployeeTypesQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GetAllDepartmentQueryResponse GetAllDepartmentQueryResponse { get; set; }
    }
}
