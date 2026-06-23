using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Rooms.Commands.UpdateRoomAvailabilityStatus
{
    public class UpdateRoomAvailabilityStatusCommandRequest : IRequest<ResponseDto<bool>>
    {
        public string SessionToken { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
