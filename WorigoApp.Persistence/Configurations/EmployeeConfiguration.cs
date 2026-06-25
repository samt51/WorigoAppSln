using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    /// <summary>
    /// EmployeeConfiguration sınıfını temsil eder.
    /// </summary>
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var employee = new Employee(1, "Ahmet", "Alan", "1.jpeg", 7, 1, 2)
            {
                DateOfBirth = new DateTime(1995, 08, 18),
                FloorNo = null,
                PhoneNumber = "+905363988981",
                Gender = true,
                StartDateOfWork = new DateTime(2026, 6, 19),
                ExitDateOfWork = null,
                LastOnlineTime = null,
                OnlineOrOfflineNow = false
            };

            var employee2 = new Employee(2, "Emre", "Alan", "1.jpeg", 7, 1, 3)
            {
                DateOfBirth = new DateTime(1995, 08, 18),
                FloorNo = null,
                PhoneNumber = "+905363988982",
                Gender = true,
                StartDateOfWork = new DateTime(2026, 6, 19),
                ExitDateOfWork = null,
                LastOnlineTime = null,
                OnlineOrOfflineNow = false
            };

            var employee3 = new Employee(3, "Yunus", "Yavaş", "1.jpeg", 3, 1, 4)
            {
                DateOfBirth = new DateTime(1995, 08, 18),
                FloorNo = null,
                PhoneNumber = "+905363988983",
                Gender = true,
                StartDateOfWork = new DateTime(2026, 6, 19),
                ExitDateOfWork = null,
                LastOnlineTime = null,
                OnlineOrOfflineNow = false
            };

            var employee4 = new Employee(4, "Fatih", "Hızlı", "1.jpeg", 9, 1, 5)
            {
                DateOfBirth = new DateTime(1995, 08, 18),
                FloorNo = null,
                PhoneNumber = "+905363988984",
                Gender = true,
                StartDateOfWork = new DateTime(2026, 6, 19),
                ExitDateOfWork = null,
                LastOnlineTime = null,
                OnlineOrOfflineNow = false
            };

            var employee5 = new Employee(5, "Mehmet", "Şiveli", "1.jpeg", 5, 1, 6)
            {
                DateOfBirth = new DateTime(1995, 08, 18),
                FloorNo = null,
                PhoneNumber = "+905363988985",
                Gender = true,
                StartDateOfWork = new DateTime(2026, 6, 19),
                ExitDateOfWork = null,
                LastOnlineTime = null,
                OnlineOrOfflineNow = false
            };

            builder.HasData(employee, employee2, employee3, employee4, employee5);

        }
    }
}
