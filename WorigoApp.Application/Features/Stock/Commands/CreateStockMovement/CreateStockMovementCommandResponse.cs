namespace WorigoApp.Application.Features.Stock.Commands.CreateStockMovement
{
    public class CreateStockMovementCommandResponse
    {
        public int Id { get; set; }
        public decimal CurrentQuantity { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
