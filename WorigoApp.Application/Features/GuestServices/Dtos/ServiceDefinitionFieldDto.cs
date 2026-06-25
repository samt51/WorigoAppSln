using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.GuestServices.Dtos
{
/// <summary>
/// ServiceDefinitionFieldDto sınıfını temsil eder.
/// </summary>
public class ServiceDefinitionFieldDto
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
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
/// Options değerini alır veya ayarlar.
/// </summary>
public IList<ServiceDefinitionFieldOptionDto> Options { get; set; } = new List<ServiceDefinitionFieldOptionDto>();
/// <summary>
/// ValidationRegex değerini alır veya ayarlar.
/// </summary>
public string? ValidationRegex { get; set; }
/// <summary>
/// DefaultValue değerini alır veya ayarlar.
/// </summary>
public string? DefaultValue { get; set; }
    }

/// <summary>
/// ServiceDefinitionFieldOptionDto sınıfını temsil eder.
/// </summary>
public class ServiceDefinitionFieldOptionDto
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
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
