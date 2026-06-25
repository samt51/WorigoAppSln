using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// ServiceCategory sınıfını temsil eder.
/// </summary>
public class ServiceCategory : EntityBase
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
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; } = string.Empty;
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string? Description { get; set; }
/// <summary>
/// IconUrl değerini alır veya ayarlar.
/// </summary>
public string? IconUrl { get; set; }
/// <summary>
/// IconKey değerini alır veya ayarlar.
/// </summary>
public string? IconKey { get; set; }
/// <summary>
/// DisplayOrder değerini alır veya ayarlar.
/// </summary>
public int DisplayOrder { get; set; }
/// <summary>
/// ShowOnHome değerini alır veya ayarlar.
/// </summary>
public bool ShowOnHome { get; set; }
/// <summary>
/// IsPopular değerini alır veya ayarlar.
/// </summary>
public bool IsPopular { get; set; }
/// <summary>
/// HomeDisplayOrder değerini alır veya ayarlar.
/// </summary>
public int? HomeDisplayOrder { get; set; }

/// <summary>
/// LegacyServiceType değerini alır veya ayarlar.
/// </summary>
public ServicesEnum? LegacyServiceType { get; set; }

/// <summary>
/// ServiceDefinitions değerini alır veya ayarlar.
/// </summary>
public IList<ServiceDefinition> ServiceDefinitions { get; set; } = new List<ServiceDefinition>();
/// <summary>
/// FlowSessions değerini alır veya ayarlar.
/// </summary>
public IList<ConversationFlowSession> FlowSessions { get; set; } = new List<ConversationFlowSession>();
    }
}
