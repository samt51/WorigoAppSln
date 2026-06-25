using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.LeaveRequests.Commands.UpdateLeaveRequestStatus
{
/// <summary>
/// UpdateLeaveRequestStatusCommandRequest sınıfını temsil eder.
/// </summary>
public class UpdateLeaveRequestStatusCommandRequest : IRequest<ResponseDto<UpdateLeaveRequestStatusCommandResponse>>
    {
/// <summary>
/// LeaveRequestId değerini alır veya ayarlar.
/// </summary>
public int LeaveRequestId { get; set; }
/// <summary>
/// ActionEmployeeId değerini alır veya ayarlar.
/// </summary>
public int ActionEmployeeId { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public LeaveRequestStatusEnum Status { get; set; }
/// <summary>
/// Note değerini alır veya ayarlar.
/// </summary>
public string? Note { get; set; }
/// <summary>
/// IsHrAction değerini alır veya ayarlar.
/// </summary>
public bool IsHrAction { get; set; }
    }
}
