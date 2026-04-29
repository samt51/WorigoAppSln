using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Stock.Dto;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Stock.Commands.CreateStockRequest
{
    public class CreateStockRequestCommandRequest : IRequest<ResponseDto<CreateStockRequestCommandResponse>>
    {
        public int HotelId { get; set; }
        public int RequestedByEmployeeId { get; set; }
        public int? AssignedManagerEmployeeId { get; set; }
        public int? DepartmentId { get; set; }
        public int? RelatedServiceRequestId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public StockRequestPriorityEnum Priority { get; set; } = StockRequestPriorityEnum.Normal;
        public IList<StockRequestItemDto> Items { get; set; } = new List<StockRequestItemDto>();
    }
}
