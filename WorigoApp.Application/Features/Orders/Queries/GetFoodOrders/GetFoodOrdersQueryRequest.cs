using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Orders.Queries.GetFoodOrders
{
    public class GetFoodOrdersQueryRequest : IRequest<ResponseDto<IList<Order>>>
    {
        public string SessionToken { get; set; } = string.Empty;
    }
}
