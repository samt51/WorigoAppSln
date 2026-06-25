using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    /// <summary>
    /// RoleConfiguration sınıfını temsil eder.
    /// </summary>
    public class RoleConfiguration : IEntityTypeConfiguration<Roles>
    {
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<Roles> builder)
        {
            var role1 = new Roles("SystemAdmin", 1);
            var role2 = new Roles("HotelAdmin", 2);
            var role3 = new Roles("Management", 3);
            var role4 = new Roles("DepartmentManager", 4);
            var role5 = new Roles("Employee", 5);
            var role6 = new Roles("Customer", 6);
            var role7 = new Roles("HRManager", 7);
            var role8 = new Roles("PurchasingManager", 8);

            builder.HasData(role1, role2, role3, role4, role5, role6, role7, role8);
        }
    }
}
