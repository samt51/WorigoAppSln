using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Images.Commands.CreateImage
{
    public class UpdateImageCommonRequest :IRequest<Response<CreateImageCommonResponse>>
    {
        public string ImageUrl { get; set; }
        public int ImageCategoryId { get; set; }
    }
}
