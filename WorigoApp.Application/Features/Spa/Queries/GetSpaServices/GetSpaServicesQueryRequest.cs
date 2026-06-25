using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Spa.Queries.GetSpaServices
{
/// <summary>
/// GetSpaServicesQueryRequest sınıfını temsil eder.
/// </summary>
public class GetSpaServicesQueryRequest : IRequest<ResponseDto<IList<SpaService>>>
    {
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
    }
}
