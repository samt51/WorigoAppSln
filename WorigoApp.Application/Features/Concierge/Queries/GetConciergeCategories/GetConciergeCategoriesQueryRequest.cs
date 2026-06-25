using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Concierge.Queries.GetConciergeCategories
{
/// <summary>
/// GetConciergeCategoriesQueryRequest sınıfını temsil eder.
/// </summary>
public class GetConciergeCategoriesQueryRequest : IRequest<ResponseDto<IList<string>>>
    {
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
    }
}
