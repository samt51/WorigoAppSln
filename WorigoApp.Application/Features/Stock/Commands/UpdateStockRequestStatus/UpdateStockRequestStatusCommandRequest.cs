using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Stock.Dto;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Stock.Commands.UpdateStockRequestStatus
{
    public class UpdateStockRequestStatusCommandRequest : IRequest<ResponseDto<UpdateStockRequestStatusCommandResponse>>
    {
        public int StockRequestId { get; set; }
        public StockRequestStatusEnum Status { get; set; }
        public string? ManagerNote { get; set; }
        public IList<StockRequestItemDto> Items { get; set; } = new List<StockRequestItemDto>();
    }
}
