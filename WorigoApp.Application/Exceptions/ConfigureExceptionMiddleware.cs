﻿using Microsoft.AspNetCore.Builder;
namespace WorigoApp.Application.Exceptions
{
    public static class ConfigureExceptionMiddleware
    {
        public static void ConfigureExceptionHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();  
        }
    }
}
