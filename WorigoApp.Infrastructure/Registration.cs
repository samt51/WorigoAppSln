using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Hangfire;
using Hangfire.SqlServer;
using WorigoApp.Application.Interfaces.Auth.Jwt.Tokens;
using WorigoApp.Application.Interfaces.Notifications;
using WorigoApp.Application.Interfaces.Translation;
using WorigoApp.Infrastructure.Notifications;
using WorigoApp.Infrastructure.Tokens;
using WorigoApp.Infrastructure.Translation;

namespace WorigoApp.Infrastructure
{
    /// <summary>
    /// Registration sınıfını temsil eder.
    /// </summary>
    public static class Registration
    {
/// <summary>
/// AddInfrastructure işlemini gerçekleştirir.
/// </summary>
public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<TokenSettings>(configuration.GetSection("JWT"));
            services.Configure<OpenAiTranslationSettings>(configuration.GetSection("OpenAI"));
            services.Configure<FirebasePushNotificationSettings>(configuration.GetSection("Firebase"));
            services.AddTransient<ITokenService, TokenService>();
            services.AddHttpClient<IChatTranslationService, OpenAiChatTranslationService>();
            services.AddHttpClient<IPushNotificationService, FirebasePushNotificationService>();
            services.AddTransient<WorigoApp.Application.Interfaces.BackgroundJobs.IDailyReportJob, WorigoApp.Infrastructure.BackgroundJobs.DailyReportJob>();

            var hangfireEnabled = configuration.GetValue<bool>("HangfireSettings:IsEnabled");
            if (hangfireEnabled)
            {
                services.AddHangfire(config => config
                    .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
                    .UseSimpleAssemblyNameTypeSerializer()
                    .UseRecommendedSerializerSettings()
                    .UseSqlServerStorage(configuration.GetConnectionString("DefaultConnection"), new SqlServerStorageOptions
                    {
                        CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                        SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                        QueuePollInterval = TimeSpan.Zero,
                        UseRecommendedIsolationLevel = true,
                        DisableGlobalLocks = true
                    }));

                services.AddHangfireServer();
            }

            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, opt =>
            {
                opt.SaveToken = true;
                opt.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"])),
                    ValidateLifetime = false,
                    ValidIssuer = configuration["JWT:Issuer"],
                    ValidAudience = configuration["JWT:Audience"],
                    ClockSkew = TimeSpan.Zero
                };
                opt.Events = new JwtBearerEvents
                {
                    OnMessageReceived = context =>
                    {
                        var accessToken = context.Request.Query["access_token"];
                        var path = context.HttpContext.Request.Path;

                        if (!string.IsNullOrWhiteSpace(accessToken) && path.StartsWithSegments("/hubs"))
                        {
                            context.Token = accessToken;
                        }

                        return Task.CompletedTask;
                    }
                };
            });
        }
    }
}
