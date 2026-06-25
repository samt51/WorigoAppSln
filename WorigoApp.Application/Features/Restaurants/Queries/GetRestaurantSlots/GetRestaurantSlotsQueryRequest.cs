using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Restaurants.Queries.GetRestaurantSlots
{
/// <summary>
/// GetRestaurantSlotsQueryRequest sınıfını temsil eder.
/// </summary>
public class GetRestaurantSlotsQueryRequest : IRequest<ResponseDto<IList<string>>>
    {
/// <summary>
/// RestaurantId değerini alır veya ayarlar.
/// </summary>
public int RestaurantId { get; set; }
/// <summary>
/// Date değerini alır veya ayarlar.
/// </summary>
public string Date { get; set; } = string.Empty;
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
    }
}
