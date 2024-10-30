namespace WorigoApp.Application.Helpers.DesignPatterns.StrategyAndFactory.Interfaces
{
    public interface IServiceStrategy<T>
    {
        Task<T> GetServiceItemAsync(int serviceItemId);
    }

}
