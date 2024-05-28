using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;

namespace WorigoApp.Application.Filters
{
    public class AddCachingToResponseAttirbute<T> : Attribute, IResultFilter
    {
        private readonly string _cacheKey;
        public AddCachingToResponseAttirbute(string cacheKey)
        {
            _cacheKey = cacheKey;
        }
        public  void OnResultExecuted(ResultExecutedContext context)
        {

        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            var memoryCache = (IMemoryCache)context.HttpContext.RequestServices.GetService(typeof(IMemoryCache));
            if (memoryCache != null)
            {
                if (memoryCache.TryGetValue(this._cacheKey, out object T))
                {
                    memoryCache.Remove(this._cacheKey);
                }
           
            }
        }
    }
}
