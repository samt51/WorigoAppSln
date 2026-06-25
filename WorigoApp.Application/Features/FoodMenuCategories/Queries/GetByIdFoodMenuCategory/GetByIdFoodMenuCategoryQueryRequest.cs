using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.FoodMenuCategories.Queries.GetByIdFoodMenuCategory
{
/// <summary>
/// GetByIdFoodMenuCategoryQueryRequest sınıfını temsil eder.
/// </summary>
public class GetByIdFoodMenuCategoryQueryRequest : IRequest<ResponseDto<GetByIdFoodMenuCategoryQueryResponse>>
    {
/// <summary>
/// GetByIdFoodMenuCategoryQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdFoodMenuCategoryQueryRequest(int foodMenuCategoryId)
        {
            this.FoodMenuCategoryId = foodMenuCategoryId;
        }
/// <summary>
/// FoodMenuCategoryId değerini alır veya ayarlar.
/// </summary>
public int FoodMenuCategoryId { get; }
    }
}
