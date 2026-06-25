using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ContentOfFoods.Commands.RemoveContentOfFoodByFoodId
{
/// <summary>
/// RemoveContentOfFoodByFoodIdRequest sınıfını temsil eder.
/// </summary>
public class RemoveContentOfFoodByFoodIdRequest : IRequest<ResponseDto<RemoveContentOfFoodByFoodIdResponse>>    
    {
/// <summary>
/// FoodId değerini alır veya ayarlar.
/// </summary>
public int FoodId { get; }
/// <summary>
/// ContentsOfFoodId değerini alır veya ayarlar.
/// </summary>
public int ContentsOfFoodId { get; }
/// <summary>
/// RemoveContentOfFoodByFoodIdRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public RemoveContentOfFoodByFoodIdRequest(int foodId, int contentOfFoodId)
        {
            this.FoodId = foodId;
            this.ContentsOfFoodId = contentOfFoodId;
        }
    }
}
