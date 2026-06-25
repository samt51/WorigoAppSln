using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using SendGrid.Helpers.Errors.Model;
using Serilog.Context;
using WorigoApp.Domain.Entites;
namespace WorigoApp.Application.Middleware.Exceptions
{
    /// <summary>
    /// ExceptionMiddleware sınıfını temsil eder.
    /// </summary>
    public class ExceptionMiddleware : LogDetailConsume, IMiddleware
    {
        private readonly ILogger<ExceptionMiddleware> _logger;
        private readonly IStringLocalizer<ObjectResult> _stringLocalizer;
/// <summary>
/// ExceptionMiddleware sınıfının yeni bir örneğini başlatır.
/// </summary>
public ExceptionMiddleware(IStringLocalizer<ObjectResult> stringLocalizer, ILogger<ExceptionMiddleware> logger) : base(logger)
        {
            _logger = logger;
            _stringLocalizer = stringLocalizer;
        }
/// <summary>
/// InvokeAsync işlemini gerçekleştirir.
/// </summary>
public async Task InvokeAsync(HttpContext httpContext, RequestDelegate next)
        {
            try
            {
                await next(httpContext);
            }
            catch (Exception ex)
            {
                var context = httpContext.User?.Identity?.IsAuthenticated != null || true ? httpContext.User.Identities.Select(x => x.FindFirst("Id"))?.FirstOrDefault() : null;
                if (context is not null)
                {
                    LogContext.PushProperty("UserId", context.Value.ToString());
                }
                _logger.Log(LogLevel.Error, ex.Message);
                await HandleExceptionAsync(httpContext, ex, _stringLocalizer);
            }
        }

        private static Task HandleExceptionAsync(HttpContext httpContext, Exception exception, IStringLocalizer _stringLocalizer)
        {
            int statusCode = GetStatusCode(exception);
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = statusCode;

            if (exception.GetType() == typeof(ValidationException))
                return httpContext.Response.WriteAsync(new ExceptionModel
                {
                    Response = new Bases.ResponseDto<ExceptionModel>().Fail(new ExceptionModel(), ((ValidationException)exception).Errors.Select(x => x.ErrorMessage).ToList(), StatusCodes.Status400BadRequest)

                }.ToString());

            string message = "";
            var memoryCache = (IMemoryCache)httpContext.RequestServices.GetService(typeof(IMemoryCache));

            if (memoryCache != null)
            {
                var cache = memoryCache.Get<IList<Translation>>("translation");
                if (cache is not null && cache.Count > 0)
                {
                    var languageCode = httpContext.Request.Headers["Accept-Language"].ToString();
                    if (languageCode is not null)
                    {
                        message = cache.Where(x => x.FieldName == "UnknownError" && x.LanguageCode == languageCode)?.FirstOrDefault()?.TranslationValue;
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(message))
            {
                message = "İşleminiz şu an gerçekleştirilemiyor.";
            }

            List<string> errors = new()
            {
               message
            };

            return httpContext.Response.WriteAsync(new ExceptionModel
            {
                Response = new Bases.ResponseDto<ExceptionModel>().Fail(errors, statusCode)
            }.ToString());

        }

        private static int GetStatusCode(Exception exception) =>
            exception switch
            {
                BadRequestException => StatusCodes.Status400BadRequest,
                NotFoundException => StatusCodes.Status400BadRequest,
                ValidationException => StatusCodes.Status422UnprocessableEntity,
                _ => StatusCodes.Status500InternalServerError
            };
    }
}
