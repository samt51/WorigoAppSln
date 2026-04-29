namespace WorigoApp.Application.Features.Stock.Dto
{
    public class StockRequestItemDto
    {
        public int StockItemId { get; set; }
        public decimal RequestedQuantity { get; set; }
        public decimal? ApprovedQuantity { get; set; }
        public decimal? FulfilledQuantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public string? Note { get; set; }
    }
}
