using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Hotels.Commands.DeleteHotel
{
    public class DeleteHotelCommandRequest : IRequest<ResponseDto<DeleteHotelCommandResponse>>
    {
        public int Id { get; set; }
    }
}
