using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Helpers
{
    /// <summary>
    /// GetDataFromCache sınıfını temsil eder.
    /// </summary>
    public class GetDataFromCache
    {
        private readonly IMemoryCache _memoryCache;
/// <summary>
/// GetDataFromCache sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetDataFromCache(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }
/// <summary>
/// GetData işlemini gerçekleştirir.
/// </summary>
public IList<ValidationMessages> GetData(string key)
        {
            var value = _memoryCache.Get<IList<ValidationMessages>>(key);
            return value;
        }
    }
}
