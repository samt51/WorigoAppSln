using WorigoApp.Domain.Enums;
using WorigoApp.Application.Features.ServiceRequests.Dtos;

namespace WorigoApp.Application.Features.ServiceRequests.Queries.GetAssignedServiceRequests
{
/// <summary>
/// GetAssignedServiceRequestsQueryResponse sınıfını temsil eder.
/// </summary>
public class GetAssignedServiceRequestsQueryResponse
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
/// RoomId değerini alır veya ayarlar.
/// </summary>
public int? RoomId { get; set; }
/// <summary>
/// CustomerId değerini alır veya ayarlar.
/// </summary>
public int? CustomerId { get; set; }
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int? DepartmentId { get; set; }
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
/// Items değerini alır veya ayarlar.
/// </summary>
public IList<ServiceRequestItemDto> Items { get; set; } = new List<ServiceRequestItemDto>();
    }
}
