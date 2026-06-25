using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    /// <summary>
    /// DepartmentConfiguration sınıfını temsil eder.
    /// </summary>
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<Department> builder)
        {
            var department = new Department(1, "Resepsiyon", "1.jpeg", 1);
            var department2 = new Department(2, "Housekeeping", "1.jpeg", 1);
            var department3 = new Department(3, "Yiyecek ve İçecek", "1.jpeg", 1);
            var department4 = new Department(4, "Teknik Servis", "1.jpeg", 1);
            var departmentManagement = new Department(5, "Yönetim", "1.jpeg", 1);

            builder.HasData(department, department2, department3, department4, departmentManagement);
        }
    }
}
