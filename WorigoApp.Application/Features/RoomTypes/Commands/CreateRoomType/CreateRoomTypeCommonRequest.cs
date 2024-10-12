using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.RoomTypes.Commands.CreateRoomType
{
    public class CreateRoomTypeCommonRequest : IRequest<Response<CreateRoomTypeCommonResponse>>
    {
        public string RoomTypeValue { get; }
        public CreateRoomTypeCommonRequest(string roomTypeValue)
        {
            this.RoomTypeValue = roomTypeValue;
        }
    }
}
