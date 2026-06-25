using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ContentOfFoods.Commands.UpdateContentOfFood
{
/// <summary>
/// UpdateContentOfFoodRequest sınıfını temsil eder.
/// </summary>
public class UpdateContentOfFoodRequest : IRequest<ResponseDto<UpdateContentOfFoodResponse>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; }
/// <summary>
/// UpdateContentOfFoodRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public UpdateContentOfFoodRequest(int id, string name)
        {
            this.Name = name;
            this.Id = id;
        }
    }
}
