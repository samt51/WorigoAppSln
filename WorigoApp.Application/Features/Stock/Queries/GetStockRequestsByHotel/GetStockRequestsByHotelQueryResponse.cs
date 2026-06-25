using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Stock.Queries.GetStockRequestsByHotel
{
/// <summary>
/// GetStockRequestsByHotelQueryResponse sınıfını temsil eder.
/// </summary>
public class GetStockRequestsByHotelQueryResponse
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
/// Description değerini alır veya ayarlar.
/// </summary>
public string? Description { get; set; }
/// <summary>
/// RequestedByEmployeeName değerini alır veya ayarlar.
/// </summary>
public string RequestedByEmployeeName { get; set; } = string.Empty;
/// <summary>
/// AssignedManagerEmployeeName değerini alır veya ayarlar.
/// </summary>
public string? AssignedManagerEmployeeName { get; set; }
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
/// ItemCount değerini alır veya ayarlar.
/// </summary>
public int ItemCount { get; set; }
    }
}
