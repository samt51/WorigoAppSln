using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Rooms.Queries.GetRooms
{
    public class GetRoomsQueryRequest : IRequest<Response<IList<GetRoomsQueryResponse>>>
    {
        public int HotelId { get; set; }
        public GetRoomsQueryRequest(int hotelid)
        {
            this.HotelId = hotelid;
        }
    }
}
