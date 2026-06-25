using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.ServiceRequests.Dtos;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequests.Commands.CreateServiceRequest
{
/// <summary>
/// CreateServiceRequestCommandRequest sınıfını temsil eder.
/// </summary>
public class CreateServiceRequestCommandRequest : IRequest<ResponseDto<CreateServiceRequestCommandResponse>>
    {
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
/// <summary>
/// RoomId değerini alır veya ayarlar.
/// </summary>
public int? RoomId { get; set; }
/// <summary>
/// CustomerId değerini alır veya ayarlar.
/// </summary>
public int? CustomerId { get; set; }
/// <summary>
/// ServiceType değerini alır veya ayarlar.
/// </summary>
public ServicesEnum ServiceType { get; set; }
/// <summary>
/// ServiceCatalogItemId değerini alır veya ayarlar.
/// </summary>
public int? ServiceCatalogItemId { get; set; }
/// <summary>
/// ServiceDefinitionId değerini alır veya ayarlar.
/// </summary>
public int? ServiceDefinitionId { get; set; }
/// <summary>
/// ConversationId değerini alır veya ayarlar.
/// </summary>
public int? ConversationId { get; set; }
/// <summary>
/// Title değerini alır veya ayarlar.
/// </summary>
public string Title { get; set; } = string.Empty;
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string? Description { get; set; }
/// <summary>
/// LanguageCode değerini alır veya ayarlar.
/// </summary>
public string LanguageCode { get; set; } = "tr-TR";
/// <summary>
/// Priority değerini alır veya ayarlar.
/// </summary>
public ServiceRequestPriorityEnum Priority { get; set; } = ServiceRequestPriorityEnum.Normal;
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
