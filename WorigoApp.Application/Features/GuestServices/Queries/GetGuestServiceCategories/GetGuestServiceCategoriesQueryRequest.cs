using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.GuestServices.Queries.GetGuestServiceCategories
{
    public class GetGuestServiceCategoriesQueryRequest : IRequest<ResponseDto<IList<GetGuestServiceCategoriesQueryResponse>>>
    {
        public int GuestStayId { get; set; }
    }
}
