using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Helpers
{
    public class GetDataFromCache
    {
        private readonly IMemoryCache _memoryCache;

        public GetDataFromCache(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public IList<ValidationMessages> GetData(string key)
        {
            var value = _memoryCache.Get<IList<ValidationMessages>>(key);
            return value;
        }
    }
}
