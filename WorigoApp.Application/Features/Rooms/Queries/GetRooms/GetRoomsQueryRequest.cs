using MediatR;

namespace WorigoApp.Application.Features.Rooms.Queries.GetRooms
{
    public class GetRoomsQueryRequest : IRequest<IList<GetRoomsQueryResponse>>
    {
        public int HotelId { get; set; }
        public GetRoomsQueryRequest(int hotelid)
        {
            this.HotelId = hotelid;
        }
    }
}
