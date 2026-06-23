using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Rooms.Queries.GetRoomAvailabilityStatus
{
    public class GetRoomAvailabilityStatusQueryRequest : IRequest<ResponseDto<RoomAvailabilityStatusResponse>>
    {
        public string SessionToken { get; set; } = string.Empty;
    }
}
