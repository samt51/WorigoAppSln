using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WorigoApp.Persistence.Context;

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
            if (pendingMigrations.Count == 0)
            {
                logger.LogInformation("Database is up to date. No pending migrations found.");
                return;
            }

            logger.LogInformation(
                "Applying {MigrationCount} pending database migration(s): {Migrations}",
                pendingMigrations.Count,
                string.Join(", ", pendingMigrations));

            dbContext.Database.Migrate();

            logger.LogInformation("Database migration completed successfully. Seed data configured with EF HasData is applied through migrations.");
        }
    }

    public class DatabaseInitializationOptions
    {
        public bool AutoMigrate { get; set; } = true;
    }
}
