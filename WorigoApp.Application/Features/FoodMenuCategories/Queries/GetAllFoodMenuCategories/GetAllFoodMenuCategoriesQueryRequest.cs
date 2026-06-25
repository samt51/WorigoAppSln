using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.FoodMenuCategories.Queries.GetAllFoodMenuCategories
{
/// <summary>
/// GetAllFoodMenuCategoriesQueryRequest sınıfını temsil eder.
/// </summary>
public class GetAllFoodMenuCategoriesQueryRequest : IRequest<ResponseDto<IList<GetAllFoodMenuCategoriesQueryResponse>>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; }
/// <summary>
/// GetAllFoodMenuCategoriesQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetAllFoodMenuCategoriesQueryRequest(int hotelId)
        {
            this.HotelId = hotelId;
        }
    }
}
