using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.LeaveRequests.Queries.GetLeaveRequestsByManager
{
/// <summary>
/// GetLeaveRequestsByManagerQueryResponse sınıfını temsil eder.
/// </summary>
public class GetLeaveRequestsByManagerQueryResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// EmployeeName değerini alır veya ayarlar.
/// </summary>
public string EmployeeName { get; set; } = string.Empty;
/// <summary>
/// DepartmentName değerini alır veya ayarlar.
/// </summary>
public string? DepartmentName { get; set; }
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
/// RequestedAt değerini alır veya ayarlar.
/// </summary>
public DateTime RequestedAt { get; set; }
    }
}
