using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ContentOfFoods.Commands.CreateContentOfFood
{
/// <summary>
/// CreateContentOfFoodRequest sınıfını temsil eder.
/// </summary>
public class CreateContentOfFoodRequest : IRequest<ResponseDto<CreateContentOfFoodResponse>>
    {
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; }
/// <summary>
/// CreateContentOfFoodRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateContentOfFoodRequest(string name)
        {
            this.Name = name;
        }
    }
}
