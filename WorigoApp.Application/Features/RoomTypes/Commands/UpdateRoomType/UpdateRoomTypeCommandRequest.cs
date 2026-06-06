using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.RoomTypes.Commands.UpdateRoomType
{
    public class UpdateRoomTypeCommandRequest : IRequest<ResponseDto<UpdateRoomTypeCommandResponse>>
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Capacity { get; set; }
        public decimal BasePrice { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
    }
}
