namespace WorigoApp.Application.Features.Stock.Commands.CreateStockItem
{
    public class CreateStockItemCommandResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal CurrentQuantity { get; set; }
        public decimal MinimumQuantity { get; set; }
    }
}
