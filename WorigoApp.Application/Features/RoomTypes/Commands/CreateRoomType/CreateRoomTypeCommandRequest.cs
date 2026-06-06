using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.RoomTypes.Commands.CreateRoomType
{
    public class CreateRoomTypeCommandRequest : IRequest<ResponseDto<CreateRoomTypeCommandResponse>>
    {
        public int HotelId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Capacity { get; set; }
        public decimal BasePrice { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
    }
}
