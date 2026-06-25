namespace WorigoApp.Application.Features.Stock.Commands.CreateStockMovement
{
/// <summary>
/// CreateStockMovementCommandResponse sınıfını temsil eder.
/// </summary>
public class CreateStockMovementCommandResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// CurrentQuantity değerini alır veya ayarlar.
/// </summary>
public decimal CurrentQuantity { get; set; }
/// <summary>
/// TotalAmount değerini alır veya ayarlar.
/// </summary>
public decimal TotalAmount { get; set; }
    }
}
