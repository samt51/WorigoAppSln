using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Services.Commands.ToggleServiceCatalogStatus
{
/// <summary>
/// ToggleServiceCatalogStatusCommandResponse sınıfını temsil eder.
/// </summary>
public class ToggleServiceCatalogStatusCommandResponse
    {
/// <summary>
/// ServiceType değerini alır veya ayarlar.
/// </summary>
public ServicesEnum ServiceType { get; set; }
/// <summary>
/// ServiceCatalogItemId değerini alır veya ayarlar.
/// </summary>
public int ServiceCatalogItemId { get; set; }
/// <summary>
/// IsActive değerini alır veya ayarlar.
/// </summary>
public bool IsActive { get; set; }
    }
}
