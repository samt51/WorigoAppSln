using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Helpers
{
    public class Util
    {

        public static string GetAcceptLanguageCodeFromToken()
        {
            var htp = new HttpContextAccessor();

            return htp.HttpContext.Request.Headers.AcceptLanguage;
        }
        public static IList<Translation> GetTranslationFromCache(string cacheKey)
        {
            var htp = new HttpContextAccessor();
            var memoryCacheService = (IMemoryCache)htp.HttpContext.RequestServices.GetService(typeof(IMemoryCache));

            var cache = memoryCacheService.Get<List<Translation>>("translation");

            return cache;
        }
    }
}
