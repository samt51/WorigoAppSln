using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Stock.Queries.GetStockRequestsByManager
{
/// <summary>
/// GetStockRequestsByManagerQueryResponse sınıfını temsil eder.
/// </summary>
public class GetStockRequestsByManagerQueryResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Title değerini alır veya ayarlar.
/// </summary>
public string Title { get; set; } = string.Empty;
/// <summary>
/// RequestedByEmployeeName değerini alır veya ayarlar.
/// </summary>
public string RequestedByEmployeeName { get; set; } = string.Empty;
/// <summary>
/// DepartmentName değerini alır veya ayarlar.
/// </summary>
public string? DepartmentName { get; set; }
/// <summary>
/// Priority değerini alır veya ayarlar.
/// </summary>
public StockRequestPriorityEnum Priority { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public StockRequestStatusEnum Status { get; set; }
/// <summary>
/// RequestedAt değerini alır veya ayarlar.
/// </summary>
public DateTime RequestedAt { get; set; }
/// <summary>
/// ManagerNote değerini alır veya ayarlar.
/// </summary>
public string? ManagerNote { get; set; }
    }
}
