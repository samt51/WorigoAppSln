using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Restaurants.Queries.GetRestaurant
{
/// <summary>
/// GetRestaurantQueryRequest sınıfını temsil eder.
/// </summary>
public class GetRestaurantQueryRequest : IRequest<ResponseDto<Restaurant>>
    {
/// <summary>
/// RestaurantId değerini alır veya ayarlar.
/// </summary>
public int RestaurantId { get; set; }
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
    }
}
