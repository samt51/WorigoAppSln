using WorigoApp.Application.Features.Foods.Queries.GetAllFoods;

namespace WorigoApp.Application.Features.FoodMenuCategories.Queries.GetByIdFoodMenuCategory
{
/// <summary>
/// GetByIdFoodMenuCategoryQueryResponse sınıfını temsil eder.
/// </summary>
public class GetByIdFoodMenuCategoryQueryResponse
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
