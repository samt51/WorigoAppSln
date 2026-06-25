using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// ServiceRequestItem sınıfını temsil eder.
/// </summary>
public class ServiceRequestItem : EntityBase
    {
/// <summary>
/// ServiceRequestId değerini alır veya ayarlar.
/// </summary>
public int ServiceRequestId { get; set; }
/// <summary>
/// ServiceRequest değerini alır veya ayarlar.
/// </summary>
public ServiceRequest ServiceRequest { get; set; } = null!;

/// <summary>
/// ServiceDefinitionId değerini alır veya ayarlar.
/// </summary>
public int? ServiceDefinitionId { get; set; }
/// <summary>
/// ServiceDefinition değerini alır veya ayarlar.
/// </summary>
public ServiceDefinition? ServiceDefinition { get; set; }

/// <summary>
/// ItemName değerini alır veya ayarlar.
/// </summary>
public string ItemName { get; set; } = string.Empty;
/// <summary>
/// Quantity değerini alır veya ayarlar.
/// </summary>
public int Quantity { get; set; } = 1;
/// <summary>
/// Note değerini alır veya ayarlar.
/// </summary>
public string? Note { get; set; }
    }
}
