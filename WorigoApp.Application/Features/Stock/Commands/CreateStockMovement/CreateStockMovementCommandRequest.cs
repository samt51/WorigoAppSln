using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Stock.Commands.CreateStockMovement
{
    public class CreateStockMovementCommandRequest : IRequest<ResponseDto<CreateStockMovementCommandResponse>>
    {
        public int HotelId { get; set; }
        public int StockItemId { get; set; }
        public int? DepartmentId { get; set; }
        public int? EmployeeId { get; set; }
        public StockMovementTypeEnum MovementType { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string? Reason { get; set; }
        public string? ReferenceType { get; set; }
        public int? ReferenceId { get; set; }
        public DateTime? OccurredAt { get; set; }
    }
}
