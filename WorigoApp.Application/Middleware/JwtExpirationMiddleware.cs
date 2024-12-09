using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Caching.Memory;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Middleware
{
    public class JwtExpirationMiddleware
    {
        private readonly RequestDelegate _next;
        public JwtExpirationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var request = context.GetRouteValue("action");

            //translation tablosunu cachte yoksa doldurur.
            await TransactionAddOrControllToCache(context);
            //ContentsOfFood tablosunu cachte yoksa doldurur.
            await CacheSetContentsOfFoodDatas(context);
            //Validasyon mesajlarını doldurur.
            await SetCacheValidationMessages(context);




            if (request is not null && request.ToString() == "Logout")
            {
                var token = context.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

                if (!string.IsNullOrWhiteSpace(token))
                {
                    context.Request.Headers["Authorization"] = "";
                    await _next(context);
                    return;
                }
                return;
            }
            else
            {
                var endpoint = context.Features.Get<IEndpointFeature>()?.Endpoint;

                var allowAnonymous = endpoint?.Metadata.GetMetadata<IAllowAnonymous>();
                var authorize = endpoint?.Metadata.GetMetadata<IAuthorizeData>();


                if (allowAnonymous != null)
                {
                    // Authorize attribute'u yok
                    // Bu, action veya controller üzerinde [AllowAnonymous] attribute'unun olduğunu gösterir.

                    await _next(context);
                }
                else
                {
                    var token = context.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

                    if (string.IsNullOrWhiteSpace(token))
                    {
                        await _next(context);
                        return;
                    }

                    // Tokenın son kullanma tarihini al
                    var tokenHandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
                    var jwtToken = (System.IdentityModel.Tokens.Jwt.JwtSecurityToken)tokenHandler.ReadToken(token);
                    var expirationDate = jwtToken.ValidTo;
                    var date = jwtToken.Payload.FirstOrDefault(x => x.Key == "exp").Value;
                    DateTime dateTime = UnixTimeStampToDateTime(long.Parse(date.ToString()));

                    // Tokenın son kullanma tarihi geçmiş mi kontrol et
                    if (DateTime.Now > dateTime)
                    {
                        // Tokenın son kullanma tarihi geçmişse hata dön
                        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                        await context.Response.WriteAsync("Token expired");
                        return;
                    }

                    // Token hala geçerliyse, sonraki middleware'e devam et
                    await _next(context);
                }
            }
        }

        public static DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            // Unix zaman damgası 1970-01-01 00:00:00 UTC tarihinden itibaren geçen saniye sayısını temsil eder
            DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            TimeSpan timeZoneOffsetSpan = TimeSpan.FromHours(3);
            DateTime localTime = unixEpoch.AddSeconds(unixTimeStamp).Add(timeZoneOffsetSpan);

            return localTime;
        }
        public async Task TransactionAddOrControllToCache(HttpContext context)
        {
            var memoryCache = (IMemoryCache)context.RequestServices.GetService(typeof(IMemoryCache));
            if (memoryCache != null)
            {
                var cache = memoryCache.Get<List<Translation>>("translation");
                if (cache is null)
                {
                    var unitOfWork = (IUnitOfWork)context.RequestServices.GetService(typeof(IUnitOfWork));
                    if (unitOfWork != null)
                    {
                        var data = await unitOfWork.GetReadRepository<Translation>().GetAllAsync();
                        memoryCache.Set<IList<Translation>>("translation", data, new MemoryCacheEntryOptions
                        {
                            AbsoluteExpiration = DateTime.Now.AddDays(1),
                            Priority = CacheItemPriority.Normal,
                        });
                    }
                }
            }
        }

        public async Task CacheSetContentsOfFoodDatas(HttpContext context)
        {
            var memoryCache = (IMemoryCache)context.RequestServices.GetService(typeof(IMemoryCache));
            if (memoryCache != null)
            {
                var cache = memoryCache.Get<List<ContentsOfFood>>("contentsOfFood");
                if (cache is null)
                {
                    var unitOfWork = (IUnitOfWork)context.RequestServices.GetService(typeof(IUnitOfWork));
                    if (unitOfWork != null)
                    {
                        var data = await unitOfWork.GetReadRepository<ContentsOfFood>().GetAllAsync();
                        memoryCache.Set<IList<ContentsOfFood>>("contentsOfFood", data, new MemoryCacheEntryOptions
                        {
                            AbsoluteExpiration = DateTime.Now.AddDays(1),
                            Priority = CacheItemPriority.Normal,
                        });
                    }
                }
            }
        }
        public async Task SetCacheValidationMessages(HttpContext context)
        {
            var memoryCache = (IMemoryCache)context.RequestServices.GetService(typeof(IMemoryCache));
            if (memoryCache != null)
            {
                var cache = memoryCache.Get<List<ValidationMessages>>("validationMessage");
                if (cache is null)
                {
                    var unitOfWork = (IUnitOfWork)context.RequestServices.GetService(typeof(IUnitOfWork));
                    if (unitOfWork != null)
                    {
                        var data = await unitOfWork.GetReadRepository<ValidationMessages>().GetAllAsync();
                        memoryCache.Set<IList<ValidationMessages>>("validationMessage", data, new MemoryCacheEntryOptions
                        {
                            AbsoluteExpiration = DateTime.Now.AddDays(30),
                            Priority = CacheItemPriority.Normal,
                        });
                    }
                }
            }
        }
    }
}
