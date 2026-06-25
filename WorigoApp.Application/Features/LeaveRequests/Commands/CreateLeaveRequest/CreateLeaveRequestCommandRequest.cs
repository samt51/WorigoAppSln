using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.LeaveRequests.Commands.CreateLeaveRequest
{
/// <summary>
/// CreateLeaveRequestCommandRequest sınıfını temsil eder.
/// </summary>
public class CreateLeaveRequestCommandRequest : IRequest<ResponseDto<CreateLeaveRequestCommandResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int EmployeeId { get; set; }
/// <summary>
/// HrEmployeeId değerini alır veya ayarlar.
/// </summary>
public int? HrEmployeeId { get; set; }
/// <summary>
/// LeaveType değerini alır veya ayarlar.
/// </summary>
public LeaveRequestTypeEnum LeaveType { get; set; }
/// <summary>
/// Title değerini alır veya ayarlar.
/// </summary>
public string Title { get; set; } = string.Empty;
/// <summary>
/// Reason değerini alır veya ayarlar.
/// </summary>
public string? Reason { get; set; }
/// <summary>
/// StartDate değerini alır veya ayarlar.
/// </summary>
public DateTime StartDate { get; set; }
/// <summary>
/// EndDate değerini alır veya ayarlar.
/// </summary>
public DateTime EndDate { get; set; }
    }
}
