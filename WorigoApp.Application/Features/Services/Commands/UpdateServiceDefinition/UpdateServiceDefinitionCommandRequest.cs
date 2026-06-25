using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Services.Dtos;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Services.Commands.UpdateServiceDefinition
{
/// <summary>
/// UpdateServiceDefinitionCommandRequest sınıfını temsil eder.
/// </summary>
public class UpdateServiceDefinitionCommandRequest : IRequest<ResponseDto<UpdateServiceDefinitionCommandResponse>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// ServiceCategoryId değerini alır veya ayarlar.
/// </summary>
public int ServiceCategoryId { get; set; }
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int? DepartmentId { get; set; }
/// <summary>
/// ServiceType değerini alır veya ayarlar.
/// </summary>
public ServicesEnum ServiceType { get; set; }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; } = string.Empty;
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string? Description { get; set; }
/// <summary>
/// ImageUrl değerini alır veya ayarlar.
/// </summary>
public string? ImageUrl { get; set; }
/// <summary>
/// OpeningMessage değerini alır veya ayarlar.
/// </summary>
public string? OpeningMessage { get; set; }
/// <summary>
/// IsVisibleToGuest değerini alır veya ayarlar.
/// </summary>
public bool IsVisibleToGuest { get; set; } = true;
/// <summary>
/// IsChargeable değerini alır veya ayarlar.
/// </summary>
public bool IsChargeable { get; set; }
/// <summary>
/// SupportsFreeText değerini alır veya ayarlar.
/// </summary>
public bool SupportsFreeText { get; set; }
/// <summary>
/// RequiresAppointment değerini alır veya ayarlar.
/// </summary>
public bool RequiresAppointment { get; set; }
/// <summary>
/// FlowUiType değerini alır veya ayarlar.
/// </summary>
public ServiceFlowUiTypeEnum? FlowUiType { get; set; }
/// <summary>
/// EstimatedDurationMinutes değerini alır veya ayarlar.
/// </summary>
public int? EstimatedDurationMinutes { get; set; }
/// <summary>
/// DisplayOrder değerini alır veya ayarlar.
/// </summary>
public int DisplayOrder { get; set; }
/// <summary>
/// Price değerini alır veya ayarlar.
/// </summary>
public decimal Price { get; set; }
/// <summary>
/// CurrencyCode değerini alır veya ayarlar.
/// </summary>
public string CurrencyCode { get; set; } = "TRY";
/// <summary>
/// IsActive değerini alır veya ayarlar.
/// </summary>
public bool IsActive { get; set; } = true;
/// <summary>
/// Fields değerini alır veya ayarlar.
/// </summary>
public IList<ServiceDefinitionFieldManageDto> Fields { get; set; } = new List<ServiceDefinitionFieldManageDto>();
    }
}
