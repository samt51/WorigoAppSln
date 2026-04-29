using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.GuestServices.Queries.GetGuestAvailableServices
{
    public class GetGuestAvailableServicesQueryRequest : IRequest<ResponseDto<IList<GetGuestAvailableServicesQueryResponse>>>
    {
        public int GuestStayId { get; set; }
    }
}
