using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Foods.Queries.GetByFood
{
/// <summary>
/// GetByIdFoodQueryRequest sınıfını temsil eder.
/// </summary>
public class GetByIdFoodQueryRequest : IRequest<ResponseDto<GetByIdFoodQueryResponse>>
    {
/// <summary>
/// GetByIdFoodQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdFoodQueryRequest(int foodId)
        {
            this.FoodId = foodId;
        }
/// <summary>
/// FoodId değerini alır veya ayarlar.
/// </summary>
public int FoodId { get; }
    }
}
