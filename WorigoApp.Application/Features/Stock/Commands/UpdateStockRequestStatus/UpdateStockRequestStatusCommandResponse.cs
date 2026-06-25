using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Stock.Commands.UpdateStockRequestStatus
{
/// <summary>
/// UpdateStockRequestStatusCommandResponse sınıfını temsil eder.
/// </summary>
public class UpdateStockRequestStatusCommandResponse
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
/// ApprovedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? ApprovedAt { get; set; }
/// <summary>
/// FulfilledAt değerini alır veya ayarlar.
/// </summary>
public DateTime? FulfilledAt { get; set; }
    }
}
