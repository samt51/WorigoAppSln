using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Concierge.Queries.GetConciergePlace
{
/// <summary>
/// GetConciergePlaceQueryRequest sınıfını temsil eder.
/// </summary>
public class GetConciergePlaceQueryRequest : IRequest<ResponseDto<ConciergePlace>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
    }
}
