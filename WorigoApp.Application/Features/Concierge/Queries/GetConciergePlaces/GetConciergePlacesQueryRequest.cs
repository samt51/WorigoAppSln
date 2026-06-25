using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Concierge.Queries.GetConciergePlaces
{
/// <summary>
/// GetConciergePlacesQueryRequest sınıfını temsil eder.
/// </summary>
public class GetConciergePlacesQueryRequest : IRequest<ResponseDto<IList<ConciergePlace>>>
    {
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
/// <summary>
/// Category değerini alır veya ayarlar.
/// </summary>
public string? Category { get; set; }
    }
}
