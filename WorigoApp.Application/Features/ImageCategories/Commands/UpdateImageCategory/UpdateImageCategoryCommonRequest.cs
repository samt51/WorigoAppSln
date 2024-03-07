using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ImageCategories.Commands.UpdateImageCategory
{
    public class UpdateImageCategoryCommonRequest :IRequest<Response<UpdateImageCategoryCommonResponse>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
