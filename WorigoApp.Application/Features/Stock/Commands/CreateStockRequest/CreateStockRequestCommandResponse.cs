using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Stock.Commands.CreateStockRequest
{
    public class CreateStockRequestCommandResponse
    {
        public int Id { get; set; }
        public StockRequestStatusEnum Status { get; set; }
        public DateTime RequestedAt { get; set; }
    }
}
