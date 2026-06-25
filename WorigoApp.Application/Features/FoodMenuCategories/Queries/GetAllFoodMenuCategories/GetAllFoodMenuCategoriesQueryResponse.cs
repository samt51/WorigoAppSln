using WorigoApp.Application.Features.Foods.Queries.GetAllFoods;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.FoodMenuCategories.Queries.GetAllFoodMenuCategories
{
/// <summary>
/// GetAllFoodMenuCategoriesQueryResponse sınıfını temsil eder.
/// </summary>
public class GetAllFoodMenuCategoriesQueryResponse
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
/// Foods değerini alır veya ayarlar.
/// </summary>
public IList<GetAllFoodsQueryResponse> Foods { get; set; }
    }
}
