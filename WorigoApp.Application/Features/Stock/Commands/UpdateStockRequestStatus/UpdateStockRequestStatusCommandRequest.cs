using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Stock.Dto;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Stock.Commands.UpdateStockRequestStatus
{
/// <summary>
/// UpdateStockRequestStatusCommandRequest sınıfını temsil eder.
/// </summary>
public class UpdateStockRequestStatusCommandRequest : IRequest<ResponseDto<UpdateStockRequestStatusCommandResponse>>
    {
/// <summary>
/// StockRequestId değerini alır veya ayarlar.
/// </summary>
public int StockRequestId { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public StockRequestStatusEnum Status { get; set; }
/// <summary>
/// ManagerNote değerini alır veya ayarlar.
/// </summary>
public string? ManagerNote { get; set; }
/// <summary>
/// Items değerini alır veya ayarlar.
/// </summary>
public IList<StockRequestItemDto> Items { get; set; } = new List<StockRequestItemDto>();
    }
}
