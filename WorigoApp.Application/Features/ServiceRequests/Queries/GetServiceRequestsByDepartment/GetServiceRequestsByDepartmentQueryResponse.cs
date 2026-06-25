using WorigoApp.Domain.Enums;
using WorigoApp.Application.Features.ServiceRequests.Dtos;

namespace WorigoApp.Application.Features.ServiceRequests.Queries.GetServiceRequestsByDepartment
{
/// <summary>
/// GetServiceRequestsByDepartmentQueryResponse sınıfını temsil eder.
/// </summary>
public class GetServiceRequestsByDepartmentQueryResponse
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
/// Description değerini alır veya ayarlar.
/// </summary>
public string? Description { get; set; }
/// <summary>
/// ServiceType değerini alır veya ayarlar.
/// </summary>
public ServicesEnum ServiceType { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public ServiceRequestStatusEnum Status { get; set; }
/// <summary>
/// CustomerId değerini alır veya ayarlar.
/// </summary>
public int? CustomerId { get; set; }
/// <summary>
/// RoomId değerini alır veya ayarlar.
/// </summary>
public int? RoomId { get; set; }
/// <summary>
/// AssignedEmployeeId değerini alır veya ayarlar.
/// </summary>
public int? AssignedEmployeeId { get; set; }
/// <summary>
/// ServiceDefinitionId değerini alır veya ayarlar.
/// </summary>
public int? ServiceDefinitionId { get; set; }
/// <summary>
/// ServiceDefinitionName değerini alır veya ayarlar.
/// </summary>
public string? ServiceDefinitionName { get; set; }
/// <summary>
/// ServiceCategoryId değerini alır veya ayarlar.
/// </summary>
public int? ServiceCategoryId { get; set; }
/// <summary>
/// ServiceCategoryName değerini alır veya ayarlar.
/// </summary>
public string? ServiceCategoryName { get; set; }
/// <summary>
/// ConversationId değerini alır veya ayarlar.
/// </summary>
public int? ConversationId { get; set; }
/// <summary>
/// RequestedAt değerini alır veya ayarlar.
/// </summary>
public DateTime RequestedAt { get; set; }
/// <summary>
/// DueAt değerini alır veya ayarlar.
/// </summary>
public DateTime? DueAt { get; set; }
/// <summary>
/// CompletedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? CompletedAt { get; set; }
/// <summary>
/// Items değerini alır veya ayarlar.
/// </summary>
public IList<ServiceRequestItemDto> Items { get; set; } = new List<ServiceRequestItemDto>();
    }
}
