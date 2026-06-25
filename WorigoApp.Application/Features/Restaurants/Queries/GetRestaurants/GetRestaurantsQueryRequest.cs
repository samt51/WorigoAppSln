using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Restaurants.Queries.GetRestaurants
{
/// <summary>
/// GetRestaurantsQueryRequest sınıfını temsil eder.
/// </summary>
public class GetRestaurantsQueryRequest : IRequest<ResponseDto<IList<Restaurant>>>
    {
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
    }
}
