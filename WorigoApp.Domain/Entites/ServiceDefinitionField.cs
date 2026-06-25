using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// ServiceDefinitionField sınıfını temsil eder.
/// </summary>
public class ServiceDefinitionField : EntityBase
    {
/// <summary>
/// ServiceDefinitionId değerini alır veya ayarlar.
/// </summary>
public int ServiceDefinitionId { get; set; }
/// <summary>
/// ServiceDefinition değerini alır veya ayarlar.
/// </summary>
public ServiceDefinition ServiceDefinition { get; set; } = null!;

/// <summary>
/// FieldKey değerini alır veya ayarlar.
/// </summary>
public string FieldKey { get; set; } = string.Empty;
/// <summary>
/// Label değerini alır veya ayarlar.
/// </summary>
public string Label { get; set; } = string.Empty;
/// <summary>
/// Placeholder değerini alır veya ayarlar.
/// </summary>
public string? Placeholder { get; set; }
/// <summary>
/// FieldType değerini alır veya ayarlar.
/// </summary>
public ServiceDefinitionFieldTypeEnum FieldType { get; set; }
/// <summary>
/// IsRequired değerini alır veya ayarlar.
/// </summary>
public bool IsRequired { get; set; }
/// <summary>
/// DisplayOrder değerini alır veya ayarlar.
/// </summary>
public int DisplayOrder { get; set; }
/// <summary>
/// OptionsJson değerini alır veya ayarlar.
/// </summary>
public string? OptionsJson { get; set; }
/// <summary>
/// ValidationRegex değerini alır veya ayarlar.
/// </summary>
public string? ValidationRegex { get; set; }
/// <summary>
/// DefaultValue değerini alır veya ayarlar.
/// </summary>
public string? DefaultValue { get; set; }

/// <summary>
/// RequestValues değerini alır veya ayarlar.
/// </summary>
public IList<ServiceRequestFieldValue> RequestValues { get; set; } = new List<ServiceRequestFieldValue>();
/// <summary>
/// Options değerini alır veya ayarlar.
/// </summary>
public IList<ServiceDefinitionFieldOption> Options { get; set; } = new List<ServiceDefinitionFieldOption>();
    }
}
