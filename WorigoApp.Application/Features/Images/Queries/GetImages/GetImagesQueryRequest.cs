using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Images.Queries.GetImages
{
    public class GetImagesQueryRequest : IRequest<Response<IList<GetImagesQueryResponse>>>
    {
        public int ImagesCategoryId { get; }
        public GetImagesQueryRequest(int imageCategoryId)
        {
            this.ImagesCategoryId = imageCategoryId;
        }
    }
}
