using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// ServiceDefinition sınıfını temsil eder.
/// </summary>
public class ServiceDefinition : EntityBase
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// Hotel değerini alır veya ayarlar.
/// </summary>
public Hotel Hotel { get; set; } = null!;

/// <summary>
/// ServiceCategoryId değerini alır veya ayarlar.
/// </summary>
public int ServiceCategoryId { get; set; }
/// <summary>
/// ServiceCategory değerini alır veya ayarlar.
/// </summary>
public ServiceCategory ServiceCategory { get; set; } = null!;

/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int? DepartmentId { get; set; }
/// <summary>
/// Department değerini alır veya ayarlar.
/// </summary>
public Department? Department { get; set; }

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
/// Fields değerini alır veya ayarlar.
/// </summary>
public IList<ServiceDefinitionField> Fields { get; set; } = new List<ServiceDefinitionField>();
/// <summary>
/// ServiceRequests değerini alır veya ayarlar.
/// </summary>
public IList<ServiceRequest> ServiceRequests { get; set; } = new List<ServiceRequest>();
/// <summary>
/// ServiceRequestItems değerini alır veya ayarlar.
/// </summary>
public IList<ServiceRequestItem> ServiceRequestItems { get; set; } = new List<ServiceRequestItem>();
/// <summary>
/// FlowSessions değerini alır veya ayarlar.
/// </summary>
public IList<ConversationFlowSession> FlowSessions { get; set; } = new List<ConversationFlowSession>();
    }
}
