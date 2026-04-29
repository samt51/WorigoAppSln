using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Persistence.Configurations
{
    public class ServiceRoleAssignmentsConfiguration : IEntityTypeConfiguration<ServiceRoleAssignments>
    {
        public void Configure(EntityTypeBuilder<ServiceRoleAssignments> builder)
        {
            var role1 = new ServiceRoleAssignments(1, (int)ServicesEnum.Menu, 17)
            {
                HotelId = 1,
                DepartmentId = 3,
                ServicesEnumId = ServicesEnum.Menu,
                Priority = 1,
                SlaMinutes = 30
            };
            var role2 = new ServiceRoleAssignments(2, (int)ServicesEnum.Menu, 18)
            {
                HotelId = 1,
                DepartmentId = 3,
                ServicesEnumId = ServicesEnum.Menu,
                Priority = 2,
                SlaMinutes = 30,
                IsPrimaryAssignment = false
            };
            var role3 = new ServiceRoleAssignments(3, (int)ServicesEnum.Menu, 19)
            {
                HotelId = 1,
                DepartmentId = 3,
                ServicesEnumId = ServicesEnum.Menu,
                Priority = 3,
                SlaMinutes = 30,
                IsPrimaryAssignment = false
            };
            var role4 = new ServiceRoleAssignments(4, (int)ServicesEnum.Menu, 20)
            {
                HotelId = 1,
                DepartmentId = 3,
                ServicesEnumId = ServicesEnum.Menu,
                Priority = 4,
                SlaMinutes = 30,
                IsPrimaryAssignment = false
            };

            var role5 = new ServiceRoleAssignments(5, (int)ServicesEnum.BellBoy, 6)
            {
                HotelId = 1,
                DepartmentId = 1,
                ServicesEnumId = ServicesEnum.BellBoy,
                Priority = 1,
                SlaMinutes = 10
            };

            builder.HasData(role1, role2, role3, role4, role5);
        }
    }
}
