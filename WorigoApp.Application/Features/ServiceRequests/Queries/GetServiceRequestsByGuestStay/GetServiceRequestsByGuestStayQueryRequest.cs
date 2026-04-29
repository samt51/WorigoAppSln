using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ServiceRequests.Queries.GetServiceRequestsByGuestStay
{
    public class GetServiceRequestsByGuestStayQueryRequest : IRequest<ResponseDto<IList<GetServiceRequestsByGuestStayQueryResponse>>>
    {
        public int GuestStayId { get; set; }
    }
}
