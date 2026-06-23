using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Orders.Queries.GetFoodOrderDetails
{
    public class GetFoodOrderDetailsQueryRequest : IRequest<ResponseDto<Order>>
    {
        public int OrderId { get; set; }
        public string SessionToken { get; set; } = string.Empty;
    }
}
