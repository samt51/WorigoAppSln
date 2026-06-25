using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.FoodMenuCategories.Commands.UpdateFoodMenuCategory
{
/// <summary>
/// UpdateFoodMenuCategoryCommonRequest sınıfını temsil eder.
/// </summary>
public class UpdateFoodMenuCategoryCommonRequest : IRequest<ResponseDto<UpdateFoodMenuCategoryCommonResponse>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; }
    }
}
