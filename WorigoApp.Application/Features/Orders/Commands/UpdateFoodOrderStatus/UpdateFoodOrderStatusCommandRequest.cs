using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Orders.Commands.UpdateFoodOrderStatus
{
    public class UpdateFoodOrderStatusCommandRequest : IRequest<ResponseDto<UpdateFoodOrderStatusResponse>>
    {
        public int OrderId { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
