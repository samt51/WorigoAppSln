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
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt =>
         opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

            services.AddSingleton<IMapper, Mapper>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
