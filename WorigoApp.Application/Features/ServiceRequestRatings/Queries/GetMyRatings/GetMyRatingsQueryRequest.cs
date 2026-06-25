using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ServiceRequestRatings.Queries.GetMyRatings
{
/// <summary>
/// GetMyRatingsQueryRequest sınıfını temsil eder.
/// </summary>
public class GetMyRatingsQueryRequest : IRequest<ResponseDto<IList<ServiceRequestRating>>>
    {
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
    }
}
