using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.GuestServices.Queries.GetGuestServiceCategoryItems
{
    public class GetGuestServiceCategoryItemsQueryRequest : IRequest<ResponseDto<IList<GetGuestServiceCategoryItemsQueryResponse>>>
    {
        public int GuestStayId { get; set; }
        public ServicesEnum ServiceType { get; set; }
    }
}
