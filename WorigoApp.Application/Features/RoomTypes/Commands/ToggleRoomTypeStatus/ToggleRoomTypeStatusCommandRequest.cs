using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.RoomTypes.Commands.ToggleRoomTypeStatus
{
    public class ToggleRoomTypeStatusCommandRequest : IRequest<ResponseDto<ToggleRoomTypeStatusCommandResponse>>
    {
        public int Id { get; set; }

        public ToggleRoomTypeStatusCommandRequest(int id)
        {
            Id = id;
        }
    }
}
