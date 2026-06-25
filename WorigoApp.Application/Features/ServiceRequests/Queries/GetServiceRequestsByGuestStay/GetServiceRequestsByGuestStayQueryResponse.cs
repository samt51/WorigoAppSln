using WorigoApp.Domain.Enums;
using WorigoApp.Application.Features.ServiceRequests.Dtos;

namespace WorigoApp.Application.Features.ServiceRequests.Queries.GetServiceRequestsByGuestStay
{
/// <summary>
/// GetServiceRequestsByGuestStayQueryResponse sınıfını temsil eder.
/// </summary>
public class GetServiceRequestsByGuestStayQueryResponse
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
/// StatusKey değerini alır veya ayarlar.
/// </summary>
public string StatusKey { get; set; } = string.Empty;
/// <summary>
/// StatusDisplayName değerini alır veya ayarlar.
/// </summary>
public string StatusDisplayName { get; set; } = string.Empty;
/// <summary>
/// LanguageCode değerini alır veya ayarlar.
/// </summary>
public string LanguageCode { get; set; } = string.Empty;
/// <summary>
/// RequestedAt değerini alır veya ayarlar.
/// </summary>
public DateTime RequestedAt { get; set; }
/// <summary>
/// CompletedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? CompletedAt { get; set; }
/// <summary>
/// AssignedEmployeeId değerini alır veya ayarlar.
/// </summary>
public int? AssignedEmployeeId { get; set; }
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
/// FieldValues değerini alır veya ayarlar.
/// </summary>
public IList<ServiceRequestFieldValueDto> FieldValues { get; set; } = new List<ServiceRequestFieldValueDto>();
/// <summary>
/// Items değerini alır veya ayarlar.
/// </summary>
public IList<ServiceRequestItemDto> Items { get; set; } = new List<ServiceRequestItemDto>();
    }
}
