using WorigoApp.Application.Features.Hotels.Queries.GetAllHotels;
using WorigoApp.Application.Features.Images.Queries.GetImages;

namespace WorigoApp.Application.Features.ImageCategories.Queries.GetAllImageCategories
{
/// <summary>
/// GetAllImageCategoriesQueryResponse sınıfını temsil eder.
/// </summary>
public class GetAllImageCategoriesQueryResponse
    {
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; }
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// Hotel değerini alır veya ayarlar.
/// </summary>
public GetAllHotelsQueryResponse Hotel { get; set; }
/// <summary>
/// Images değerini alır veya ayarlar.
/// </summary>
public IList<GetImagesQueryResponse> Images { get; set; }
    }
}
