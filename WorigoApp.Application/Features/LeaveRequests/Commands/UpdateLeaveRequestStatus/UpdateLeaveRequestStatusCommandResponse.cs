using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.LeaveRequests.Commands.UpdateLeaveRequestStatus
{
/// <summary>
/// UpdateLeaveRequestStatusCommandResponse sınıfını temsil eder.
/// </summary>
public class UpdateLeaveRequestStatusCommandResponse
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
/// ManagerActionAt değerini alır veya ayarlar.
/// </summary>
public DateTime? ManagerActionAt { get; set; }
/// <summary>
/// HrActionAt değerini alır veya ayarlar.
/// </summary>
public DateTime? HrActionAt { get; set; }
    }
}
