using System.Threading.Tasks;

namespace WorigoApp.Application.Interfaces.BackgroundJobs
{
/// <summary>
/// IDailyReportJob arayüzünü tanımlar.
/// </summary>
public interface IDailyReportJob
    {
        Task SendDailyReportsAsync();
    }
}
