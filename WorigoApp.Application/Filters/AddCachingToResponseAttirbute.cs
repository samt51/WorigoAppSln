using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;

namespace WorigoApp.Application.Filters
{
    /// <summary>
    /// AddCachingToResponseAttirbute sınıfını temsil eder.
    /// </summary>
    public class AddCachingToResponseAttirbute : Attribute, IResultFilter
    {
        private readonly string _cacheKey;
/// <summary>
/// AddCachingToResponseAttirbute sınıfının yeni bir örneğini başlatır.
/// </summary>
public AddCachingToResponseAttirbute(string cacheKey)
        {
            _cacheKey = cacheKey;
        }
/// <summary>
/// OnResultExecuted işlemini gerçekleştirir.
/// </summary>
public void OnResultExecuted(ResultExecutedContext context)
        {
            var memoryCache = (IMemoryCache)context.HttpContext.RequestServices.GetService(typeof(IMemoryCache));
            if (memoryCache != null)
            {
                memoryCache.Remove(_cacheKey);
            }
        }
/// <summary>
/// OnResultExecuting işlemini gerçekleştirir.
/// </summary>
public void OnResultExecuting(ResultExecutingContext context)
        {
            //throw new NotImplementedException();
        }
    }
}
