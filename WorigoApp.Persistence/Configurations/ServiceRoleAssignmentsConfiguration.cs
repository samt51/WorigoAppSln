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

            var role6 = Assignment(1006, ServicesEnum.HouseKeeping, 12, 2, 1, 20);
            var role7 = Assignment(1007, ServicesEnum.AmenityRequest, 12, 2, 1, 20);
            var role8 = Assignment(1008, ServicesEnum.WakeUpCall, 4, 1, 1, 5);
            var role9 = Assignment(1009, ServicesEnum.TechnicalNeed, 21, 4, 1, 30);
            var role10 = Assignment(1010, ServicesEnum.Connection, 21, 4, 2, 30);
            var role11 = Assignment(1011, ServicesEnum.DryCleaner, 10, 2, 1, 60);
            var role12 = Assignment(1012, ServicesEnum.SpaMessage, 25, 5, 1, 60);
            var role13 = Assignment(1013, ServicesEnum.HealthAndSafety, 8, 1, 1, 10);
            var role14 = Assignment(1014, ServicesEnum.TravelOrTransportation, 5, 1, 1, 30);
            var role15 = Assignment(1015, ServicesEnum.ValetParking, 6, 1, 1, 20);
            var role16 = Assignment(1016, ServicesEnum.Minibar, 20, 3, 1, 30);
            var role17 = Assignment(1017, ServicesEnum.StayExtension, 4, 1, 1, 15);
            var role18 = Assignment(1018, ServicesEnum.MedicalAssistance, 8, 1, 1, 5);

            builder.HasData(role1, role2, role3, role4, role5, role6, role7, role8, role9, role10, role11, role12, role13, role14, role15, role16, role17, role18);
        }

        private static ServiceRoleAssignments Assignment(int id, ServicesEnum serviceType, int employeeTypeRoleId, int departmentId, int priority, int slaMinutes)
        {
            return new ServiceRoleAssignments(id, (int)serviceType, employeeTypeRoleId)
            {
                HotelId = 1,
                DepartmentId = departmentId,
                ServicesEnumId = serviceType,
                Priority = priority,
                SlaMinutes = slaMinutes,
                IsPrimaryAssignment = priority == 1
            };
        }
    }
}
