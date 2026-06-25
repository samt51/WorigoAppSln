using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// ServiceDefinitionFieldOption sınıfını temsil eder.
/// </summary>
public class ServiceDefinitionFieldOption : EntityBase
    {
/// <summary>
/// ServiceDefinitionFieldId değerini alır veya ayarlar.
/// </summary>
public int ServiceDefinitionFieldId { get; set; }
/// <summary>
/// ServiceDefinitionField değerini alır veya ayarlar.
/// </summary>
public ServiceDefinitionField ServiceDefinitionField { get; set; } = null!;

/// <summary>
/// Value değerini alır veya ayarlar.
/// </summary>
public string Value { get; set; } = string.Empty;
/// <summary>
/// Label değerini alır veya ayarlar.
/// </summary>
public string Label { get; set; } = string.Empty;
/// <summary>
/// DisplayOrder değerini alır veya ayarlar.
/// </summary>
public int DisplayOrder { get; set; }
    }
}
