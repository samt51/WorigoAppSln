using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Services.Commands.ToggleServiceCatalogStatus
{
/// <summary>
/// ToggleServiceCatalogStatusCommandRequest sınıfını temsil eder.
/// </summary>
public class ToggleServiceCatalogStatusCommandRequest : IRequest<ResponseDto<ToggleServiceCatalogStatusCommandResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
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
