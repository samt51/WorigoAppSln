namespace WorigoApp.Application.Features.Stock.Commands.CreateStockItem
{
/// <summary>
/// CreateStockItemCommandResponse sınıfını temsil eder.
/// </summary>
public class CreateStockItemCommandResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; } = string.Empty;
/// <summary>
/// CurrentQuantity değerini alır veya ayarlar.
/// </summary>
public decimal CurrentQuantity { get; set; }
/// <summary>
/// MinimumQuantity değerini alır veya ayarlar.
/// </summary>
public decimal MinimumQuantity { get; set; }
    }
}
