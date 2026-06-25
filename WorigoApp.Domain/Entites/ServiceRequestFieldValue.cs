using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// ServiceRequestFieldValue sınıfını temsil eder.
/// </summary>
public class ServiceRequestFieldValue : EntityBase
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
/// ServiceDefinitionFieldId değerini alır veya ayarlar.
/// </summary>
public int ServiceDefinitionFieldId { get; set; }
/// <summary>
/// ServiceDefinitionField değerini alır veya ayarlar.
/// </summary>
public ServiceDefinitionField ServiceDefinitionField { get; set; } = null!;

/// <summary>
/// FieldKey değerini alır veya ayarlar.
/// </summary>
public string FieldKey { get; set; } = string.Empty;
/// <summary>
/// Value değerini alır veya ayarlar.
/// </summary>
public string? Value { get; set; }
    }
}
