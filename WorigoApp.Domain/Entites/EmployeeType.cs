using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class EmployeeType : EntityBase
    {
        public EmployeeType()
        {
            
        }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public IList<Employee> Employees { get; set; }
        
        public EmployeeType(int id,string name, int departmentId)
        {
            this.Id = id;
            this.Name = name;
            this.DepartmentId = departmentId;

        }
    }
}
