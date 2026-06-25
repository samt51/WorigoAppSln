using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Orders.Queries.GetFoodOrderDetails
{
/// <summary>
/// GetFoodOrderDetailsQueryRequest sınıfını temsil eder.
/// </summary>
public class GetFoodOrderDetailsQueryRequest : IRequest<ResponseDto<Order>>
    {
/// <summary>
/// OrderId değerini alır veya ayarlar.
/// </summary>
public int OrderId { get; set; }
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
    }
}
