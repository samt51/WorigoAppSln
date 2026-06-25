using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ContentOfFoods.Queries.GetAllContentByFoodId
{
/// <summary>
/// GetAllContentByFoodIdRequest sınıfını temsil eder.
/// </summary>
public class GetAllContentByFoodIdRequest : IRequest<ResponseDto<IList<GetAllContentByFoodIdResponse>>>
    {
/// <summary>
/// FoodId değerini alır veya ayarlar.
/// </summary>
public int FoodId { get; }
/// <summary>
/// GetAllContentByFoodIdRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetAllContentByFoodIdRequest(int foodId)
        {
            this.FoodId = foodId;
        }
    }
}
