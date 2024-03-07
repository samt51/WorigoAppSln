using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Images.Commands.UpdateImage
{
    public class UpdateImageCommonRequest :IRequest<Response<UpdateImageCommonResponse>>
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
    }
}
