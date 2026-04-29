using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Stock.Queries.GetStockRequestsByManager
{
    public class GetStockRequestsByManagerQueryResponse
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string RequestedByEmployeeName { get; set; } = string.Empty;
        public string? DepartmentName { get; set; }
        public StockRequestPriorityEnum Priority { get; set; }
        public StockRequestStatusEnum Status { get; set; }
        public DateTime RequestedAt { get; set; }
        public string? ManagerNote { get; set; }
    }
}
