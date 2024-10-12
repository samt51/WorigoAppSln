using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Services.Queries.GetAllServices
{
    public class GetAllServicesQueryRequest : IRequest<Response<IList<GetAllServicesQueryResponse>>>
    {
        public int HotelId { get; set; }
        public GetAllServicesQueryRequest(int hotelid)
        {
            this.HotelId = hotelid;
        }
    }
}
