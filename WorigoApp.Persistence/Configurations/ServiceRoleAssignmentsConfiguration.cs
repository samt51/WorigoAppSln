using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Persistence.Configurations
{
    /// <summary>
    /// ServiceRoleAssignmentsConfiguration sınıfını temsil eder.
    /// </summary>
    public class ServiceRoleAssignmentsConfiguration : IEntityTypeConfiguration<ServiceRoleAssignments>
    {
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<ServiceRoleAssignments> builder)
        {
            var role1 = new ServiceRoleAssignments(1, (int)ServicesEnum.Menu, 7)
            {
                HotelId = 1,
                DepartmentId = 3,
                ServicesEnumId = ServicesEnum.Menu,
                Priority = 1,
                SlaMinutes = 30
            };
            var role2 = new ServiceRoleAssignments(2, (int)ServicesEnum.Menu, 6)
            {
                HotelId = 1,
                DepartmentId = 3,
                ServicesEnumId = ServicesEnum.Menu,
                Priority = 2,
                SlaMinutes = 30,
                IsPrimaryAssignment = false
            };
            var role3 = new ServiceRoleAssignments(3, (int)ServicesEnum.Menu, 7)
            {
                HotelId = 1,
                DepartmentId = 3,
                ServicesEnumId = ServicesEnum.Menu,
                Priority = 3,
                SlaMinutes = 30,
                IsPrimaryAssignment = false
            };
            var role4 = new ServiceRoleAssignments(4, (int)ServicesEnum.Menu, 6)
            {
                HotelId = 1,
                DepartmentId = 3,
                ServicesEnumId = ServicesEnum.Menu,
                Priority = 4,
                SlaMinutes = 30,
                IsPrimaryAssignment = false
            };

            var role5 = new ServiceRoleAssignments(5, (int)ServicesEnum.BellBoy, 3)
            {
                HotelId = 1,
                DepartmentId = 1,
                ServicesEnumId = ServicesEnum.BellBoy,
                Priority = 1,
                SlaMinutes = 10
            };

            var role6 = Assignment(1006, ServicesEnum.HouseKeeping, 5, 2, 1, 20);
            var role7 = Assignment(1007, ServicesEnum.AmenityRequest, 5, 2, 1, 20);
            var role8 = Assignment(1008, ServicesEnum.WakeUpCall, 3, 1, 1, 5);
            var role9 = Assignment(1009, ServicesEnum.TechnicalNeed, 9, 4, 1, 30);
            var role10 = Assignment(1010, ServicesEnum.Connection, 9, 4, 1, 30);
            var role11 = Assignment(1011, ServicesEnum.DryCleaner, 4, 2, 1, 60);
            var role12 = Assignment(1012, ServicesEnum.SpaMessage, 3, 1, 1, 60);
            var role13 = Assignment(1013, ServicesEnum.HealthAndSafety, 3, 1, 1, 10);
            var role14 = Assignment(1014, ServicesEnum.TravelOrTransportation, 3, 1, 1, 30);
            var role15 = Assignment(1015, ServicesEnum.ValetParking, 3, 1, 1, 20);
            var role16 = Assignment(1016, ServicesEnum.Minibar, 7, 3, 1, 30);
            var role17 = Assignment(1017, ServicesEnum.StayExtension, 3, 1, 1, 15);
            var role18 = Assignment(1018, ServicesEnum.MedicalAssistance, 3, 1, 1, 5);
            var role19 = Assignment(1019, ServicesEnum.BellBoy, 3, 1, 2, 10);
            var role20 = Assignment(1020, ServicesEnum.HouseKeeping, 5, 2, 2, 20);
            var role21 = Assignment(1021, ServicesEnum.HouseKeeping, 5, 2, 3, 25);
            var role22 = Assignment(1022, ServicesEnum.HouseKeeping, 4, 2, 4, 30);
            var role23 = Assignment(1023, ServicesEnum.AmenityRequest, 5, 2, 2, 20);
            var role24 = Assignment(1024, ServicesEnum.AmenityRequest, 5, 2, 3, 25);
            var role25 = Assignment(1025, ServicesEnum.DryCleaner, 5, 2, 2, 60);
            var role26 = Assignment(1026, ServicesEnum.DryCleaner, 5, 2, 3, 60);
            var role27 = Assignment(1027, ServicesEnum.TechnicalNeed, 9, 4, 2, 30);
            var role28 = Assignment(1028, ServicesEnum.TechnicalNeed, 9, 4, 3, 30);
            var role29 = Assignment(1029, ServicesEnum.TechnicalNeed, 8, 4, 4, 30);
            var role30 = Assignment(1030, ServicesEnum.Connection, 8, 4, 2, 30);
            var role31 = Assignment(1031, ServicesEnum.WakeUpCall, 3, 1, 2, 5);
            var role32 = Assignment(1032, ServicesEnum.WakeUpCall, 2, 1, 3, 5);
            var role33 = Assignment(1033, ServicesEnum.HealthAndSafety, 2, 1, 2, 10);
            var role34 = Assignment(1034, ServicesEnum.HealthAndSafety, 2, 1, 3, 10);
            var role35 = Assignment(1035, ServicesEnum.TravelOrTransportation, 3, 1, 2, 30);
            var role36 = Assignment(1036, ServicesEnum.ValetParking, 3, 1, 2, 20);
            var role37 = Assignment(1037, ServicesEnum.Minibar, 7, 3, 2, 30);
            var role38 = Assignment(1038, ServicesEnum.Minibar, 7, 3, 3, 30);
            var role39 = Assignment(1039, ServicesEnum.StayExtension, 3, 1, 2, 15);
            var role40 = Assignment(1040, ServicesEnum.MedicalAssistance, 2, 1, 2, 5);

            builder.HasData(
                role1, role2, role3, role4, role5, role6, role7, role8, role9, role10,
                role11, role12, role13, role14, role15, role16, role17, role18, role19, role20,
                role21, role22, role23, role24, role25, role26, role27, role28, role29, role30,
                role31, role32, role33, role34, role35, role36, role37, role38, role39, role40);
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
