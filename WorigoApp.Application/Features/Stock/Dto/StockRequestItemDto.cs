namespace WorigoApp.Application.Features.Stock.Dto
{
/// <summary>
/// StockRequestItemDto sınıfını temsil eder.
/// </summary>
public class StockRequestItemDto
    {
/// <summary>
/// StockItemId değerini alır veya ayarlar.
/// </summary>
public int StockItemId { get; set; }
/// <summary>
/// RequestedQuantity değerini alır veya ayarlar.
/// </summary>
public decimal RequestedQuantity { get; set; }
/// <summary>
/// ApprovedQuantity değerini alır veya ayarlar.
/// </summary>
public decimal? ApprovedQuantity { get; set; }
/// <summary>
/// FulfilledQuantity değerini alır veya ayarlar.
/// </summary>
public decimal? FulfilledQuantity { get; set; }
/// <summary>
/// UnitPrice değerini alır veya ayarlar.
/// </summary>
public decimal? UnitPrice { get; set; }
/// <summary>
/// Note değerini alır veya ayarlar.
/// </summary>
public string? Note { get; set; }
    }
}
