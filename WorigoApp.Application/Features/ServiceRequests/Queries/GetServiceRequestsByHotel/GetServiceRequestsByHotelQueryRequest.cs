using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequests.Queries.GetServiceRequestsByHotel
{
    public class GetServiceRequestsByHotelQueryRequest : IRequest<ResponseDto<IList<GetServiceRequestsByHotelQueryResponse>>>
    {
        public int HotelId { get; set; }
        public ServiceRequestStatusEnum? Status { get; set; }
    }
}
