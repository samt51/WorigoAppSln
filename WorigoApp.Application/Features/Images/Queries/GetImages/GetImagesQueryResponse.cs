using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Images.Queries.GetImages
{
/// <summary>
/// GetImagesQueryResponse sınıfını temsil eder.
/// </summary>
public class GetImagesQueryResponse
    {
/// <summary>
/// ImageUrl değerini alır veya ayarlar.
/// </summary>
public string ImageUrl { get; set; }
/// <summary>
/// ImageCategoryId değerini alır veya ayarlar.
/// </summary>
public int ImageCategoryId { get; set; }
    }
}
