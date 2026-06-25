using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Foods.Queries.GetAllFoods
{
/// <summary>
/// GetAllFoodsQueryResponse sınıfını temsil eder.
/// </summary>
public class GetAllFoodsQueryResponse
    {
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; }
/// <summary>
/// Price değerini alır veya ayarlar.
/// </summary>
public decimal Price { get; set; }
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string Description { get; set; }
/// <summary>
/// FoodMenuCategoryId değerini alır veya ayarlar.
/// </summary>
public int FoodMenuCategoryId { get; set; }
    }
}
