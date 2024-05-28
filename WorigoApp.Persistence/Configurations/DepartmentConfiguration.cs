using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {

        public void Configure(EntityTypeBuilder<Department> builder)
        {
            var department = new Department(1, "Ön Büro Resepsiyon Departmanı", "1.jpeg", 1);
            var department2 = new Department(2, "Housekeeping Departmanı", "1.jpeg", 1);
            var department3 = new Department(3, "Yiyecek İçecek ve Mutfak Departmanı", "1.jpeg", 1);
            var department4 = new Department(4, "Teknik Servis Departmanı", "1.jpeg", 1);
            var department11 = new Department(5, "Sağlık Kulübü & Spa Departmanı", "1.jpeg", 1);

            builder.HasData(department, department2, department3, department4, department11);
        }
    }
}
