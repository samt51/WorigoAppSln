using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Services.Commands.CreateService
{
    public class CreateServiceCommandRequest : IRequest<Response<CreateServiceCommandResponse>>
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int HotelId { get; set; }
    }
}
