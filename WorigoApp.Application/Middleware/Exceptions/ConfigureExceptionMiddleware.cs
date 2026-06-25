using Microsoft.AspNetCore.Builder;

namespace WorigoApp.Application.Middleware.Exceptions
{
    /// <summary>
    /// ConfigureExceptionMiddleware sınıfını temsil eder.
    /// </summary>
    public static class ConfigureExceptionMiddleware
    {
/// <summary>
/// ConfigureExceptionHandlingMiddleware işlemini gerçekleştirir.
/// </summary>
public static void ConfigureExceptionHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
