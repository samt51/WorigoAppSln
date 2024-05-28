using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Reflection;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Filters;
using WorigoApp.Application.Middleware.Exceptions;
using WorigoApp.Application.Pipelines.Behaviour;
using WorigoApp.CrossCuttingConcerns.Logging.Logger;
using WorigoApp.CrossCuttingConcerns.Logging.Serilog;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace WorigoApp.Application
{
    public static class Registration
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddTransient<ExceptionMiddleware>();


            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));
            services.AddRulesFromAssemblyContaining(assembly, typeof(BaseRules));

            services.AddValidatorsFromAssembly(assembly);

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

            ValidatorOptions.Global.LanguageManager.Culture = new CultureInfo("tr");

            services.Configure<RequestLocalizationOptions>(cfg =>
            {
                cfg.DefaultRequestCulture = new("tr-TR");
                CultureInfo[] cultures = new CultureInfo[]
                    {
                        new("tr-TR"),
                        new("en-US"),
                        new("fr-FR")
                    };


                cfg.SupportedCultures = cultures;
                cfg.SupportedUICultures = cultures;

            });
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            services.AddMvc(x =>
            {
                x.Filters.Add(typeof(ValidatorActionFilter));
            }).AddFluentValidation(fvc => fvc.RegisterValidatorsFromAssemblyContaining<ObjectResult>())
             .AddSessionStateTempDataProvider();



            services.AddSingleton<LoggerServiceBase, FileLogger>();

  


            return services;

        }
        private static IServiceCollection AddRulesFromAssemblyContaining(
          this IServiceCollection services,
          Assembly assembly,
          Type type)
        {
            var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
            foreach (var item in types)
                services.AddTransient(item);

            return services;
        }

    }
}
