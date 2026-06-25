using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Stock.Commands.CreateStockItem
{
/// <summary>
/// CreateStockItemCommandRequest sınıfını temsil eder.
/// </summary>
public class CreateStockItemCommandRequest : IRequest<ResponseDto<CreateStockItemCommandResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int? DepartmentId { get; set; }
/// <summary>
/// Code değerini alır veya ayarlar.
/// </summary>
public string Code { get; set; } = string.Empty;
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; } = string.Empty;
/// <summary>
/// Unit değerini alır veya ayarlar.
/// </summary>
public string Unit { get; set; } = "Adet";
/// <summary>
/// CurrentQuantity değerini alır veya ayarlar.
/// </summary>
public decimal CurrentQuantity { get; set; }
/// <summary>
/// MinimumQuantity değerini alır veya ayarlar.
/// </summary>
public decimal MinimumQuantity { get; set; }
/// <summary>
/// LastPurchasePrice değerini alır veya ayarlar.
/// </summary>
public decimal? LastPurchasePrice { get; set; }
/// <summary>
/// AverageUnitCost değerini alır veya ayarlar.
/// </summary>
public decimal AverageUnitCost { get; set; }
/// <summary>
/// IsCritical değerini alır veya ayarlar.
/// </summary>
public bool IsCritical { get; set; }
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string? Description { get; set; }
    }
}
