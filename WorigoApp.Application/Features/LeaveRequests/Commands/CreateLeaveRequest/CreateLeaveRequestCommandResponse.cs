using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.LeaveRequests.Commands.CreateLeaveRequest
{
/// <summary>
/// CreateLeaveRequestCommandResponse sınıfını temsil eder.
/// </summary>
public class CreateLeaveRequestCommandResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public LeaveRequestStatusEnum Status { get; set; }
/// <summary>
/// TotalDayCount değerini alır veya ayarlar.
/// </summary>
public decimal TotalDayCount { get; set; }
/// <summary>
/// RequestedAt değerini alır veya ayarlar.
/// </summary>
public DateTime RequestedAt { get; set; }
    }
}
