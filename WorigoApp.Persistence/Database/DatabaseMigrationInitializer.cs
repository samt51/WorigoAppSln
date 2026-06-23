using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WorigoApp.Persistence.Context;
using WorigoApp.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WorigoApp.Persistence.Database
{
    public static class DatabaseMigrationInitializer
    {
        public static void ApplyDatabaseMigrations(this IServiceProvider serviceProvider, IConfiguration configuration, ILogger logger)
        {
            var options = configuration.GetSection("DatabaseInitialization").Get<DatabaseInitializationOptions>()
                ?? new DatabaseInitializationOptions();

            if (!options.AutoMigrate)
            {
                logger.LogInformation("Database auto migration is disabled.");
                return;
            }

            using var scope = serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            var pendingMigrations = dbContext.Database.GetPendingMigrations().ToList();
            if (pendingMigrations.Count > 0)
            {
                logger.LogInformation(
                    "Applying {MigrationCount} pending database migration(s): {Migrations}",
                    pendingMigrations.Count,
                    string.Join(", ", pendingMigrations));

                dbContext.Database.Migrate();
                logger.LogInformation("Database migration completed successfully.");
            }
            else
            {
                logger.LogInformation("Database is up to date. No pending migrations found.");
            }

            // Always run the runtime seeding check to ensure test users and employee logins are present
            SeedUsersAndEmployees(dbContext, logger);
        }

        private static void SeedUsersAndEmployees(AppDbContext dbContext, ILogger logger)
        {
            try
            {
                logger.LogInformation("Starting runtime database seeding for testing users...");

                var defaultPasswordHash = Application.Helpers.PasswordHash.HashPassword("123456");

                // 1. Ensure general test role users exist (System Admin)
                var sysAdminEmail = "sysadmin@stayzora.com";
                var sysAdminUser = dbContext.Set<Users>().FirstOrDefault(u => u.Email == sysAdminEmail);
                if (sysAdminUser == null)
                {
                    sysAdminUser = new Users
                    {
                        Email = sysAdminEmail,
                        Password = defaultPasswordHash,
                        RoleId = 1, // SystemAdmin
                        UserName = "sysadmin"
                    };
                    dbContext.Set<Users>().Add(sysAdminUser);
                    logger.LogInformation("Seeded SystemAdmin: {Email}", sysAdminEmail);
                }
                dbContext.SaveChanges();

                // 2. Ensure clear, distinct Service Staff accounts exist (Email, RoleId, Name, Surname, EmployeeTypeId, Phone)
                var serviceStaff = new List<(string Email, int RoleId, string Name, string Surname, int EmployeeTypeId, string Phone)>
                {
                    ("resepsiyon@stayzora.com", 5, "Resepsiyon", "Görevlisi", 4, "+905001112233"),
                    ("temizlik@stayzora.com", 5, "Temizlik", "Görevlisi", 12, "+905001112244"),
                    ("teknik@stayzora.com", 5, "Teknik", "Servis", 22, "+905001112255"),
                    ("yemek@stayzora.com", 5, "Yemek", "Servisi", 20, "+905001112266"),
                    ("hoteladmin@stayzora.com", 2, "Otel", "Yöneticisi", 501, "+905001112277")
                };

                foreach (var staff in serviceStaff)
                {
                    var user = dbContext.Set<Users>().FirstOrDefault(u => u.Email == staff.Email);
                    if (user == null)
                    {
                        user = new Users
                        {
                            Email = staff.Email,
                            Password = defaultPasswordHash,
                            RoleId = staff.RoleId,
                            UserName = staff.Email.Split('@')[0]
                        };
                        dbContext.Set<Users>().Add(user);
                        dbContext.SaveChanges(); // Save to generate ID
                        logger.LogInformation("Seeded user account: {Email}", staff.Email);
                    }

                    // Ensure linked Employee record exists
                    var emp = dbContext.Set<Employee>().FirstOrDefault(e => e.UserId == user.Id || (e.Name == staff.Name && e.Surname == staff.Surname));
                    if (emp == null)
                    {
                        emp = new Employee
                        {
                            Name = staff.Name,
                            Surname = staff.Surname,
                            ImageUrl = "1.jpeg",
                            EmployeeTypeId = staff.EmployeeTypeId,
                            HotelId = 1,
                            UserId = user.Id,
                            PhoneNumber = staff.Phone,
                            DateOfBirth = new DateTime(1995, 08, 18),
                            StartDateOfWork = DateTime.Today,
                            Status = true,
                            IsAvailableForTask = true
                        };
                        dbContext.Set<Employee>().Add(emp);
                        dbContext.SaveChanges();
                        logger.LogInformation("Created and linked Employee record for {Name} {Surname}", staff.Name, staff.Surname);
                    }
                    else if (!emp.UserId.HasValue)
                    {
                        emp.UserId = user.Id;
                        dbContext.SaveChanges();
                        logger.LogInformation("Linked existing Employee {Name} {Surname} to user {Email}", emp.Name, emp.Surname, staff.Email);
                    }
                }

                // 3. Ensure all other existing Employees have a linked Users record
                var employees = dbContext.Set<Employee>().ToList();
                foreach (var emp in employees)
                {
                    bool needsUser = false;
                    Users linkedUser = null;

                    if (emp.UserId.HasValue)
                    {
                        linkedUser = dbContext.Set<Users>().FirstOrDefault(u => u.Id == emp.UserId.Value);
                        if (linkedUser == null)
                        {
                            needsUser = true; // UserId is set but points to non-existent user
                        }
                    }
                    else
                    {
                        needsUser = true;
                    }

                    if (needsUser)
                    {
                        // Generate a clean email based on employee details
                        var sanitizedFirstName = SanitizeName(emp.Name);
                        var sanitizedLastName = SanitizeName(emp.Surname);
                        var email = $"{sanitizedFirstName}.{sanitizedLastName}{emp.Id}@stayzora.com".ToLowerInvariant();

                        // Ensure email uniqueness
                        var count = 1;
                        var baseEmail = $"{sanitizedFirstName}.{sanitizedLastName}".ToLowerInvariant();
                        while (dbContext.Set<Users>().Any(u => u.Email == email))
                        {
                            email = $"{baseEmail}{emp.Id}_{count}@stayzora.com".ToLowerInvariant();
                            count++;
                        }

                        // Map employee type to a suitable role
                        int roleId = 5; // Default to Employee (Role 5)
                        if (emp.EmployeeTypeId.HasValue)
                        {
                            var empTypeId = emp.EmployeeTypeId.Value;
                            if (empTypeId == 1 || empTypeId == 9 || empTypeId == 14 || empTypeId == 21)
                            {
                                roleId = 4; // DepartmentManager
                            }
                            else if (empTypeId == 501)
                            {
                                roleId = 2; // HotelAdmin
                            }
                            else if (empTypeId == 500)
                            {
                                roleId = 3; // Management / CEO
                            }
                        }

                        var newUser = new Users
                        {
                            Email = email,
                            Password = defaultPasswordHash,
                            RoleId = roleId,
                            UserName = email.Split('@')[0]
                        };

                        dbContext.Set<Users>().Add(newUser);
                        dbContext.SaveChanges(); // Save to get the generated Id

                        emp.UserId = newUser.Id;
                        dbContext.SaveChanges();

                        logger.LogInformation("Created user account for employee {EmpName} {EmpSurname}: {Email} (Role ID: {RoleId})", emp.Name, emp.Surname, email, roleId);
                    }
                }

                logger.LogInformation("Runtime database seeding completed successfully.");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred during database seeding.");
            }
        }

        private static string SanitizeName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return "staff";
            
            // Replace Turkish characters
            var sb = new System.Text.StringBuilder(name);
            sb.Replace("ı", "i").Replace("İ", "i")
              .Replace("ğ", "g").Replace("Ğ", "g")
              .Replace("ü", "u").Replace("Ü", "u")
              .Replace("ş", "s").Replace("Ş", "s")
              .Replace("ö", "o").Replace("Ö", "o")
              .Replace("ç", "c").Replace("Ç", "c");

            var result = sb.ToString();
            // Remove non-alphabetic characters
            return new string(result.Where(char.IsLetter).ToArray());
        }
    }

    public class DatabaseInitializationOptions
    {
        public bool AutoMigrate { get; set; } = true;
    }
}
