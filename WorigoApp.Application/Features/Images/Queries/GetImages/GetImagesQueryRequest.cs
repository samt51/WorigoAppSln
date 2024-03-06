using MediatR;

namespace WorigoApp.Application.Features.Images.Queries.GetImages
{
    public class GetImagesQueryRequest : IRequest<IList<GetImagesQueryResponse>>
    {
        public int ImagesCategoryId { get; }
        public GetImagesQueryRequest(int imageCategoryId)
        {
            this.ImagesCategoryId = imageCategoryId;
        }
    }
}
