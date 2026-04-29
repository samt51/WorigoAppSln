using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ImageCategories.Commands.CreateImageCategory
{
    public class UpdateImageCategoryCommonRequest :IRequest<ResponseDto<UpdateImageCategoryCommonResponse>>
    {
        public string Name { get; set; }
        public int HotelId { get; set; }
    }
}
