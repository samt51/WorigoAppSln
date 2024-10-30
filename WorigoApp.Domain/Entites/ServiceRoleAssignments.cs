using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class ServiceRoleAssignments : EntityBase
    {
        public ServiceRoleAssignments()
        {

        }
        public ServiceRoleAssignments(int id, int serviceId, int employeeTypeRoleId)
        {
            this.Id = id;
            this.ServiceId = serviceId;
            this.EmployeeTypeRoleId = employeeTypeRoleId;
        }
        public int ServiceId { get; set; }
        public int EmployeeTypeRoleId { get; set; }
    }
}
