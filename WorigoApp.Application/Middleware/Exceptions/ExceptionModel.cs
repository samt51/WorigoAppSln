using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace WorigoApp.Application.Middleware.Exceptions
{
    /// <summary>
    /// ExceptionModel sınıfını temsil eder.
    /// </summary>
    public class ExceptionModel
    {
        //public IEnumerable<string> Errors { get; set; }

/// <summary>
/// Response değerini alır veya ayarlar.
/// </summary>
public Bases.ResponseDto<ExceptionModel> Response { get; set; }
/// <summary>
/// ToString işlemini gerçekleştirir.
/// </summary>
public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
    /// <summary>
    /// LogDetailConsume sınıfını temsil eder.
    /// </summary>
    public class LogDetailConsume
    {
        private readonly ILogger<ExceptionMiddleware> _logger;
/// <summary>
/// LogDetailConsume sınıfının yeni bir örneğini başlatır.
/// </summary>
public LogDetailConsume(ILogger<ExceptionMiddleware> logger)
        {
            _logger = logger;
        }
    }
    //public class ErrorStatusCode
    //{
    //    public int StatusCode { get; set; }
    //}
}
