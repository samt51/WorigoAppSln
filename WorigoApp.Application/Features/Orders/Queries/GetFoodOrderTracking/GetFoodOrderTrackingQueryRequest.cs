using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Orders.Dtos;

namespace WorigoApp.Application.Features.Orders.Queries.GetFoodOrderTracking
{
/// <summary>
/// GetFoodOrderTrackingQueryRequest sınıfını temsil eder.
/// </summary>
public class GetFoodOrderTrackingQueryRequest : IRequest<ResponseDto<OrderTrackingDto>>
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
