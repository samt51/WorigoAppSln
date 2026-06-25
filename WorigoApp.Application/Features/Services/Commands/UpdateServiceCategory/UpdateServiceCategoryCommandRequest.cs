using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Services.Commands.UpdateServiceCategory
{
/// <summary>
/// UpdateServiceCategoryCommandRequest sınıfını temsil eder.
/// </summary>
public class UpdateServiceCategoryCommandRequest : IRequest<ResponseDto<UpdateServiceCategoryCommandResponse>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
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
/// IsActive değerini alır veya ayarlar.
/// </summary>
public bool IsActive { get; set; } = true;
    }
}
