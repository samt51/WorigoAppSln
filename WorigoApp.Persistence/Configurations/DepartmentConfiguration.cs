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
            var department5 = new Department(5, "İnsan Kaynakları Departmanı", "1.jpeg", 1);
            var department6 = new Department(6, "Muhasebe Departmanı", "1.jpeg", 1);
            var department7 = new Department(7, "Satınalma Departmanı", "1.jpeg", 1);
            var department8 = new Department(8, "Satış ve Pazarlama Departmanı", "1.jpeg", 1);
            var department9 = new Department(9, "Bilgi İşlem Departmanı ", "1.jpeg", 1);
            var department10 = new Department(10, "Güvenlik Departmanı", "1.jpeg", 1);
            var department11 = new Department(11, "Sağlık Kulübü & Spa Departmanı", "1.jpeg", 1);


            builder.HasData(department, department2, department3, department4, department5, department6, department7, department8, department9
                , department10, department11);

        }
    }
}
