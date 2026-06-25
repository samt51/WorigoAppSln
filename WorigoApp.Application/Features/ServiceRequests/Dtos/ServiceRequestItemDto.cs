namespace WorigoApp.Application.Features.ServiceRequests.Dtos
{
/// <summary>
/// ServiceRequestItemDto sınıfını temsil eder.
/// </summary>
public class ServiceRequestItemDto
    {
/// <summary>
/// ServiceDefinitionId değerini alır veya ayarlar.
/// </summary>
public int? ServiceDefinitionId { get; set; }
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
