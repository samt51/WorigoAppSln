using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Stock.Commands.UpdateStockRequestStatus
{
    public class UpdateStockRequestStatusCommandResponse
    {
        public int Id { get; set; }
        public StockRequestStatusEnum Status { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public DateTime? FulfilledAt { get; set; }
    }
}
