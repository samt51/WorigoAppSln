using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.RoomTypes.Commands.DeleteRoomType
{
    public class DeleteRoomTypeCommandRequest : IRequest<ResponseDto<DeleteRoomTypeCommandResponse>>
    {
        public int Id { get; set; }

        public DeleteRoomTypeCommandRequest(int id)
        {
            Id = id;
        }
    }
}
