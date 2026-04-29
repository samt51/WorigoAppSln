using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Stock.Commands.CreateStockItem
{
    public class CreateStockItemCommandRequest : IRequest<ResponseDto<CreateStockItemCommandResponse>>
    {
        public int HotelId { get; set; }
        public int? DepartmentId { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Unit { get; set; } = "Adet";
        public decimal CurrentQuantity { get; set; }
        public decimal MinimumQuantity { get; set; }
        public decimal? LastPurchasePrice { get; set; }
        public decimal AverageUnitCost { get; set; }
        public bool IsCritical { get; set; }
        public string? Description { get; set; }
    }
}
