using MediatR;
using System.Collections.Generic;

namespace WorigoApp.Application.Features.RoomTypes.Queries.GetRoomTypes
{
    public class GetRoomTypesQueryRequest : IRequest<IList<GetRoomTypesQueryResponse>>
    {
        public int HotelId { get; set; }
        public bool? ActiveOnly { get; set; }

        public GetRoomTypesQueryRequest(int hotelId, bool? activeOnly = null)
        {
            HotelId = hotelId;
            ActiveOnly = activeOnly;
        }
    }
}
