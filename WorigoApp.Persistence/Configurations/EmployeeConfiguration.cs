using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var employee = new Employee(1, "Ahmet", "Alan", "1.jpeg", 20, 1, 2);

            var employee2 = new Employee(2, "Emre", "Alan", "1.jpeg", 20, 1, 3);

            var employee3 = new Employee(3, "Yunus", "Yavaş", "1.jpeg", 6, 1, 4);

            var employee4 = new Employee(4, "Fatih", "Hızlı", "1.jpeg", 22, 1, 5);

            var employee5 = new Employee(5, "Mehmet", "Şiveli", "1.jpeg", 25, 1, 6);

            builder.HasData(employee, employee2, employee3, employee4, employee5);

        }
    }
}
