using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace WorigoApp.Application.Middleware.Exceptions
{
    public class ExceptionModel
    {
        //public IEnumerable<string> Errors { get; set; }

        public Bases.Response<ExceptionModel> Response { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
    public class LogDetailConsume
    {
        private readonly ILogger<ExceptionMiddleware> _logger;
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
