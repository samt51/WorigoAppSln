using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.Repositories;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Persistence.Concrete.Mapping;
using WorigoApp.Persistence.Concrete.Repositories;
using WorigoApp.Persistence.Concrete.UnitOfWorks;
using WorigoApp.Persistence.Context;

namespace WorigoApp.Persistence
{
    /// <summary>
    /// Registration sınıfını temsil eder.
    /// </summary>
    public static class Registration
    {
/// <summary>
/// AddPersistence işlemini gerçekleştirir.
/// </summary>
public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("DefaultConnection connection string is missing.");
            }

            services.AddDbContext<AppDbContext>(opt =>
                opt.UseSqlServer(connectionString));


            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

            services.AddSingleton<IMapper, Mapper>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
