using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Stock.Dto;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Stock.Commands.CreateStockRequest
{
/// <summary>
/// CreateStockRequestCommandRequest sınıfını temsil eder.
/// </summary>
public class CreateStockRequestCommandRequest : IRequest<ResponseDto<CreateStockRequestCommandResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// RequestedByEmployeeId değerini alır veya ayarlar.
/// </summary>
public int RequestedByEmployeeId { get; set; }
/// <summary>
/// AssignedManagerEmployeeId değerini alır veya ayarlar.
/// </summary>
public int? AssignedManagerEmployeeId { get; set; }
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int? DepartmentId { get; set; }
/// <summary>
/// RelatedServiceRequestId değerini alır veya ayarlar.
/// </summary>
public int? RelatedServiceRequestId { get; set; }
/// <summary>
/// Title değerini alır veya ayarlar.
/// </summary>
public string Title { get; set; } = string.Empty;
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string? Description { get; set; }
/// <summary>
/// Priority değerini alır veya ayarlar.
/// </summary>
public StockRequestPriorityEnum Priority { get; set; } = StockRequestPriorityEnum.Normal;
/// <summary>
/// Items değerini alır veya ayarlar.
/// </summary>
public IList<StockRequestItemDto> Items { get; set; } = new List<StockRequestItemDto>();
    }
}
