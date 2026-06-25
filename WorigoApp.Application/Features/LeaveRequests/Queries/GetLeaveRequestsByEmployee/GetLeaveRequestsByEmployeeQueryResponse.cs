using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.LeaveRequests.Queries.GetLeaveRequestsByEmployee
{
/// <summary>
/// GetLeaveRequestsByEmployeeQueryResponse sınıfını temsil eder.
/// </summary>
public class GetLeaveRequestsByEmployeeQueryResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Title değerini alır veya ayarlar.
/// </summary>
public string Title { get; set; } = string.Empty;
/// <summary>
/// LeaveType değerini alır veya ayarlar.
/// </summary>
public LeaveRequestTypeEnum LeaveType { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public LeaveRequestStatusEnum Status { get; set; }
/// <summary>
/// StartDate değerini alır veya ayarlar.
/// </summary>
public DateTime StartDate { get; set; }
/// <summary>
/// EndDate değerini alır veya ayarlar.
/// </summary>
public DateTime EndDate { get; set; }
/// <summary>
/// TotalDayCount değerini alır veya ayarlar.
/// </summary>
public decimal TotalDayCount { get; set; }
/// <summary>
/// ManagerNote değerini alır veya ayarlar.
/// </summary>
public string? ManagerNote { get; set; }
/// <summary>
/// HrNote değerini alır veya ayarlar.
/// </summary>
public string? HrNote { get; set; }
    }
}
