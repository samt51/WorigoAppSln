using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Stock.Queries.GetStockRequestsByHotel
{
    public class GetStockRequestsByHotelQueryResponse
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string RequestedByEmployeeName { get; set; } = string.Empty;
        public string? AssignedManagerEmployeeName { get; set; }
        public string? DepartmentName { get; set; }
        public StockRequestPriorityEnum Priority { get; set; }
        public StockRequestStatusEnum Status { get; set; }
        public DateTime RequestedAt { get; set; }
        public int ItemCount { get; set; }
    }
}
