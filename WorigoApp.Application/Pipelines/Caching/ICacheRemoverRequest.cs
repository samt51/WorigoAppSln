namespace WorigoApp.Application.Pipelines.Caching
{
    public interface ICacheRemoverRequest
    {
        string CacheKey { get; }
        bool ByPassCache { get; }
    }
}
