using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Images.Queries.GetImages
{
    public class GetImagesQueryResponse
    {
        public string ImageUrl { get; set; }
        public int ImageCategoryId { get; set; }
    }
}
