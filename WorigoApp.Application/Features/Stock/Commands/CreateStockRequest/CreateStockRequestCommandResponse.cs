using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Stock.Commands.CreateStockRequest
{
/// <summary>
/// CreateStockRequestCommandResponse sınıfını temsil eder.
/// </summary>
public class CreateStockRequestCommandResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public StockRequestStatusEnum Status { get; set; }
/// <summary>
/// RequestedAt değerini alır veya ayarlar.
/// </summary>
public DateTime RequestedAt { get; set; }
    }
}
