using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Spa.Queries.GetSpaSlots
{
/// <summary>
/// GetSpaSlotsQueryRequest sınıfını temsil eder.
/// </summary>
public class GetSpaSlotsQueryRequest : IRequest<ResponseDto<IList<string>>>
    {
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
