using MediatR;

namespace WorigoApp.Application.Features.Services.Queries.GetAllServices
{
    public class GetAllServicesQueryRequest : IRequest<IList<GetAllServicesQueryResponse>>
    {
        public int HotelId { get; set; }
        public GetAllServicesQueryRequest(int hotelid)
        {
            this.HotelId = hotelid;
        }
    }
}
