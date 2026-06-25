namespace WorigoApp.Application.Features.ServiceRequests.Dtos
{
/// <summary>
/// ServiceRequestFieldValueDto sınıfını temsil eder.
/// </summary>
public class ServiceRequestFieldValueDto
    {
/// <summary>
/// ServiceDefinitionFieldId değerini alır veya ayarlar.
/// </summary>
public int ServiceDefinitionFieldId { get; set; }
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
