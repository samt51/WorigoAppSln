using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    /// <summary>
    /// EmployeeTypeConfiguration sınıfını temsil eder.
    /// </summary>
    public class EmployeeTypeConfiguration : IEntityTypeConfiguration<EmployeeType>
    {
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<EmployeeType> builder)
        {
            var employeeType1 = new EmployeeType(1, "Genel Müdür / Otel Yöneticisi", 5);
            var employeeType2 = new EmployeeType(2, "Resepsiyon Müdürü", 1);
            var employeeType3 = new EmployeeType(3, "Resepsiyonist", 1);
            var employeeType4 = new EmployeeType(4, "Kat Hizmetleri Müdürü", 2);
            var employeeType5 = new EmployeeType(5, "Temizlik Görevlisi", 2);
            var employeeType6 = new EmployeeType(6, "F&B Müdürü", 3);
            var employeeType7 = new EmployeeType(7, "Servis ve Mutfak Elemanı", 3);
            var employeeType8 = new EmployeeType(8, "Teknik Müdür", 4);
            var employeeType9 = new EmployeeType(9, "Teknik Personel", 4);

            builder.HasData(employeeType1, employeeType2, employeeType3, employeeType4, employeeType5, employeeType6, employeeType7, employeeType8, employeeType9);
        }
    }
}
