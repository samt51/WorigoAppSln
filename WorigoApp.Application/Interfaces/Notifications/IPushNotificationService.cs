namespace WorigoApp.Application.Interfaces.Notifications
{
/// <summary>
/// IPushNotificationService arayüzünü tanımlar.
/// </summary>
public interface IPushNotificationService
    {
        Task SendToDeviceAsync(
            string deviceToken,
            string title,
            string body,
            IDictionary<string, string>? data = null,
            CancellationToken cancellationToken = default);
    }
}
