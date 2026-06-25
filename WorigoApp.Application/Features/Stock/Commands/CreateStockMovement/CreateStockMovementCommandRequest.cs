using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Stock.Commands.CreateStockMovement
{
/// <summary>
/// CreateStockMovementCommandRequest sınıfını temsil eder.
/// </summary>
public class CreateStockMovementCommandRequest : IRequest<ResponseDto<CreateStockMovementCommandResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// StockItemId değerini alır veya ayarlar.
/// </summary>
public int StockItemId { get; set; }
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int? DepartmentId { get; set; }
/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int? EmployeeId { get; set; }
/// <summary>
/// MovementType değerini alır veya ayarlar.
/// </summary>
public StockMovementTypeEnum MovementType { get; set; }
/// <summary>
/// Quantity değerini alır veya ayarlar.
/// </summary>
public decimal Quantity { get; set; }
/// <summary>
/// UnitPrice değerini alır veya ayarlar.
/// </summary>
public decimal UnitPrice { get; set; }
/// <summary>
/// Reason değerini alır veya ayarlar.
/// </summary>
public string? Reason { get; set; }
/// <summary>
/// ReferenceType değerini alır veya ayarlar.
/// </summary>
public string? ReferenceType { get; set; }
/// <summary>
/// ReferenceId değerini alır veya ayarlar.
/// </summary>
public int? ReferenceId { get; set; }
/// <summary>
/// OccurredAt değerini alır veya ayarlar.
/// </summary>
public DateTime? OccurredAt { get; set; }
    }
}
