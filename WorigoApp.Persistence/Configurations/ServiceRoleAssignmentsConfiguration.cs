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
            var role1 = new ServiceRoleAssignments(1, (int)ServicesEnum.Menu, 17);
            var role2 = new ServiceRoleAssignments(2, (int)ServicesEnum.Menu, 18);
            var role3 = new ServiceRoleAssignments(3, (int)ServicesEnum.Menu, 19);
            var role4 = new ServiceRoleAssignments(4, (int)ServicesEnum.Menu, 20);


            var role5 = new ServiceRoleAssignments(5, (int)ServicesEnum.BellBoy, 6);



        }
    }
}
