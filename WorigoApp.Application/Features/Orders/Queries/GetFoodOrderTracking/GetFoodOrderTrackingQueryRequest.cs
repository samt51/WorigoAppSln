using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Orders.Dtos;

namespace WorigoApp.Application.Features.Orders.Queries.GetFoodOrderTracking
{
    public class GetFoodOrderTrackingQueryRequest : IRequest<ResponseDto<OrderTrackingDto>>
    {
        public int OrderId { get; set; }
        public string SessionToken { get; set; } = string.Empty;
    }
}
