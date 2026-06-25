using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Foods.Queries.GetAllFoods
{
/// <summary>
/// GetAllFoodsQueryRequest sınıfını temsil eder.
/// </summary>
public class GetAllFoodsQueryRequest : IRequest<ResponseDto<IList<GetAllFoodsQueryResponse>>>
    {
/// <summary>
/// FoodMenuCategoryId değerini alır veya ayarlar.
/// </summary>
public int FoodMenuCategoryId { get; }
/// <summary>
/// GetAllFoodsQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetAllFoodsQueryRequest(int foodMenuCategoryId)
        {
            this.FoodMenuCategoryId = foodMenuCategoryId;
        }
    }
}
