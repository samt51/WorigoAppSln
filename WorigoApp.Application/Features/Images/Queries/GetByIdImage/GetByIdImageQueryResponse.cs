namespace WorigoApp.Application.Features.Images.Queries.GetByIdImage
{
/// <summary>
/// GetByIdImageQueryResponse sınıfını temsil eder.
/// </summary>
public class GetByIdImageQueryResponse
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
