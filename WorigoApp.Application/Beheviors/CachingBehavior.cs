using MediatR;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Text.Json;
using WorigoApp.Application.Pipelines.Caching;

namespace WorigoApp.Application.Beheviors
{
    public class CachingBehavior<TRequet, TResponse> : IPipelineBehavior<TRequet, TResponse>
        where TRequet : IRequest<TResponse>, ICachableRequest
    {
        private readonly CacheSettings _cacheSettings;
        private readonly IDistributedCache _cache;
        private readonly ILogger<CachingBehavior<TRequet, TResponse>> _logger;

        public CachingBehavior(ILogger<CachingBehavior<TRequet, TResponse>> logger, IDistributedCache cache, IConfiguration configuration)
        {
            _cacheSettings = configuration.GetSection("CacheSettings").Get<CacheSettings>() ?? throw new InvalidOperationException();
            _cache = cache;
            _logger = logger;
        }

        public async Task<TResponse> Handle(TRequet request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (request.ByPassCache)
            {
                return await next();
            }
            TResponse response;

            byte[]? cachedResponse = await _cache.GetAsync(request.CacheKey, cancellationToken);

            if (cachedResponse is not null)
            {
                response = JsonSerializer.Deserialize<TResponse>(Encoding.Default.GetString(cachedResponse));
                _logger.LogInformation($"Fetch From Cache ->{request.CacheKey}");
            }
            else
            {
                response = await getResponseAndAddToCache(request, next, cancellationToken);
            }
            return response;
        }

        private async Task<TResponse?> getResponseAndAddToCache(TRequet request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            TResponse response = await next();

            TimeSpan slidingExpiration = request.SlidingExpiration ?? TimeSpan.FromDays(_cacheSettings.SlidingExpiration);

            DistributedCacheEntryOptions cacheEntryOptions = new() { SlidingExpiration = slidingExpiration };

            byte[] serializeData = Encoding.Default.GetBytes(JsonSerializer.Serialize(response));

            await _cache.SetAsync(request.CacheKey, serializeData, cacheEntryOptions, cancellationToken);
            _logger.LogInformation($"Added to Cache ->{request.CacheKey}");

            if (request.CacheGroupKey != null)
            {
                await addCacheGroupKey(request, slidingExpiration, cancellationToken);
            }

            return response;
        }

        private async Task addCacheGroupKey(TRequet request, TimeSpan slidingExpiration, CancellationToken cancellationToken)
        {
            byte[]? cacheGroupCache = await _cache.GetAsync(request.CacheKey, cancellationToken);
            HashSet<string> cacheKeyInGroup;

            if (cacheGroupCache != null)
            {
                cacheKeyInGroup = JsonSerializer.Deserialize<HashSet<string>>(Encoding.Default.GetString(cacheGroupCache));

                if (!cacheKeyInGroup.Contains(request.CacheKey))
                    cacheKeyInGroup.Add(request.CacheKey);
            }
            else
            {
                cacheKeyInGroup = new HashSet<string>(new[] { request.CacheKey });

                byte[] newcacheGroupCache = JsonSerializer.SerializeToUtf8Bytes(cacheKeyInGroup);

                byte[]? cacheGroupCacheSlidingExpirationCache = await _cache.GetAsync(key: $"{request.CacheGroupKey}SlidingExpiration", cancellationToken);

                int? cacheGroupCacheSlidingExpirationValue = null;
                if (cacheGroupCacheSlidingExpirationCache != null)
                    cacheGroupCacheSlidingExpirationValue = Convert.ToInt32(Encoding.Default.GetString(cacheGroupCacheSlidingExpirationCache));
                if (cacheGroupCacheSlidingExpirationValue == null || slidingExpiration.TotalSeconds > cacheGroupCacheSlidingExpirationValue)
                    cacheGroupCacheSlidingExpirationValue = Convert.ToInt32(slidingExpiration.TotalSeconds);

                byte[] serializeCachedGroupSlidingExpirationData = JsonSerializer.SerializeToUtf8Bytes(cacheGroupCacheSlidingExpirationValue);

                DistributedCacheEntryOptions cacheOptions =
                    new() { SlidingExpiration = TimeSpan.FromSeconds(Convert.ToDouble(cacheGroupCacheSlidingExpirationValue)) };

                await _cache.SetAsync(key: request.CacheGroupKey!, newcacheGroupCache, cacheOptions, cancellationToken);
                _logger.LogInformation($"Added to Cache {request.CacheGroupKey}");

                await _cache.SetAsync(key: $"{request.CacheGroupKey}SlidingExpiration",
                    serializeCachedGroupSlidingExpirationData, cacheOptions, cancellationToken);

                _logger.LogInformation($"Added to Cache --> {request.CacheGroupKey}SlidingExpiration");

            }
        }
    }
}
