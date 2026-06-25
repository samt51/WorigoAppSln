using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.GuestServices.Queries.GetGuestServiceCategories
{
/// <summary>
/// GetGuestServiceCategoriesQueryRequest sınıfını temsil eder.
/// </summary>
public class GetGuestServiceCategoriesQueryRequest : IRequest<ResponseDto<IList<GetGuestServiceCategoriesQueryResponse>>>
    {
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
    }
}
