using MediatR;

namespace WorigoApp.Application.Features.Images.Queries.GetImages
{
/// <summary>
/// GetImagesQueryRequest sınıfını temsil eder.
/// </summary>
public class GetImagesQueryRequest : IRequest<IList<GetImagesQueryResponse>>
    {
/// <summary>
/// ImagesCategoryId değerini alır veya ayarlar.
/// </summary>
public int ImagesCategoryId { get; }
/// <summary>
/// GetImagesQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetImagesQueryRequest(int imageCategoryId)
        {
            this.ImagesCategoryId = imageCategoryId;
        }
    }
}
