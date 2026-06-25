using Microsoft.OpenApi.Models;
using WorigoApp.Persistence;
using WorigoApp.Application;
using WorigoApp.Infrastructure;
using WorigoApp.Persistence.Context;
using WorigoApp.Application.Middleware;
using Serilog.Core;
using Serilog;
using Serilog.Sinks.MSSqlServer;
using System.Collections.ObjectModel;
using Microsoft.AspNetCore.HttpLogging;
using Serilog.Context;
using WorigoApp.Application.Middleware.Exceptions;
using MediatR;
using WorigoApp.Application.Pipelines.Behaviour;
using WorigoApp.Application.Filters;
using WorigoApp.Api.Hubs;
using WorigoApp.Persistence.Database;
using Hangfire;
using WorigoApp.Application.Interfaces.BackgroundJobs;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddSignalR();
        builder.Services.AddHttpClient();
        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(policy =>
            {
                policy.SetIsOriginAllowed(origin => true)
                      .AllowAnyMethod()
                      .AllowAnyHeader()
                      .AllowCredentials();
            });
        });
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddHttpContextAccessor();
        builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

        var env = builder.Environment;

        builder.Configuration
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json", optional: false)
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

        builder.Services.AddPersistence(builder.Configuration);
        builder.Services.AddApplication();
        builder.Services.AddInfrastructure(builder.Configuration);
        builder.Services.AddHttpContextAccessor();

        var loggerConfiguration = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File("logs/log.txt")
            .Enrich.FromLogContext()
            .MinimumLevel.Information();

        if (!builder.Environment.IsDevelopment())
        {
            loggerConfiguration.WriteTo.MSSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), "loglama", autoCreateSqlTable: true, columnOptions: new ColumnOptions
            {
                AdditionalColumns = new Collection<SqlColumn>
                {
                    new SqlColumn("UserId",System.Data.SqlDbType.VarChar)
                }
            });
        }

        Logger log = loggerConfiguration.CreateLogger();

        builder.Host.UseSerilog(log);
        builder.Services.AddMemoryCache();

        builder.Services.AddHttpLogging(logging =>
        {
            logging.LoggingFields = HttpLoggingFields.All;
            logging.RequestHeaders.Add("sec-ch-ua");
            logging.MediaTypeOptions.AddText("application/javascript");
            logging.RequestBodyLogLimit = 4096;
            logging.ResponseBodyLogLimit = 4096;
        });

        builder.Services.AddSwaggerGen(c =>
        {
            c.OperationFilter<DescriptionOperationFilter>();

            c.SwaggerDoc("v1", new OpenApiInfo { Title = "WorigoApp API", Version = "v1", Description = "WorigoApp API swagger client." });
            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
            {
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "'Bearer' yazıp boşluk bıraktıktan sonra Token'ı Girebilirsiniz \r\n\r\n Örneğin: \"Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9\""
            });
            c.AddSecurityRequirement(new OpenApiSecurityRequirement()
            {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }

            });
        });

        builder.Services.AddControllersWithViews()
                        .AddViewLocalization();

        var app = builder.Build();

        app.Services.ApplyDatabaseMigrations(app.Configuration, app.Logger);

        // Configure the HTTP request pipeline.
        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseSerilogRequestLogging();
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseCors();
        app.UseMiddleware<JwtExpirationMiddleware>();

        app.ConfigureExceptionHandlingMiddleware();
        app.UseAuthentication();
        app.UseAuthorization();

        var isHangfireEnabled = app.Configuration.GetValue<bool>("HangfireSettings:IsEnabled");
        if (isHangfireEnabled)
        {
            app.UseHangfireDashboard("/hangfire", new DashboardOptions
            {
                Authorization = Array.Empty<Hangfire.Dashboard.IDashboardAuthorizationFilter>()
            });

            using (var serviceScope = app.Services.CreateScope())
            {
                var recurringJobManager = serviceScope.ServiceProvider.GetRequiredService<IRecurringJobManager>();
                recurringJobManager.AddOrUpdate<IDailyReportJob>(
                    "daily-morning-report",
                    job => job.SendDailyReportsAsync(),
                    Cron.Daily(8)
                );
            }
        }
        app.Use(async (context, next) =>
        {
            var username = context.User?.Identity?.IsAuthenticated != null || true ? context.User.Identities.Select(x => x.FindFirst("Id"))?.FirstOrDefault() : null;
            if (username is not null)
            {
                LogContext.PushProperty("UserId", username.Value.ToString());
            }

            await next();
        });

        app.MapControllers();
        app.MapHub<HotelOperationsHub>("/hubs/hotel-operations");

        app.Run();
    }
}

