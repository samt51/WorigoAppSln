using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ContentOfFoods.Commands.AddContentOfFoodByFoodId
{
/// <summary>
/// AddContentOfFoodByFoodIdRequest sınıfını temsil eder.
/// </summary>
public class AddContentOfFoodByFoodIdRequest : IRequest<ResponseDto<AddContentOfFoodByFoodIdResponse>>
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
/// AddContentOfFoodByFoodIdRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public AddContentOfFoodByFoodIdRequest(int foodId, int contentOfFoodId)
        {
            this.FoodId = foodId;
            this.ContentsOfFoodId = contentOfFoodId;
        }
    }
}
