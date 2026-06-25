using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.GuestServices.Queries.GetGuestServiceCategoryItems
{
/// <summary>
/// GetGuestServiceCategoryItemsQueryRequest sınıfını temsil eder.
/// </summary>
public class GetGuestServiceCategoryItemsQueryRequest : IRequest<ResponseDto<IList<GetGuestServiceCategoryItemsQueryResponse>>>
    {
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
/// <summary>
/// ServiceType değerini alır veya ayarlar.
/// </summary>
public ServicesEnum ServiceType { get; set; }
    }
}
