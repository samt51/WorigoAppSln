using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Orders.Queries.GetFoodOrders
{
/// <summary>
/// GetFoodOrdersQueryRequest sınıfını temsil eder.
/// </summary>
public class GetFoodOrdersQueryRequest : IRequest<ResponseDto<IList<Order>>>
    {
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
    }
}
