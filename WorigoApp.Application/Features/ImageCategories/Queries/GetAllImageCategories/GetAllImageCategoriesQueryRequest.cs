using MediatR;

namespace WorigoApp.Application.Features.ImageCategories.Queries.GetAllImageCategories
{
/// <summary>
/// GetAllImageCategoriesQueryRequest sınıfını temsil eder.
/// </summary>
public class GetAllImageCategoriesQueryRequest : IRequest<IList<GetAllImageCategoriesQueryResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// GetAllImageCategoriesQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetAllImageCategoriesQueryRequest(int hotelid)
        {
            this.HotelId = hotelid;
        }
    }
}
