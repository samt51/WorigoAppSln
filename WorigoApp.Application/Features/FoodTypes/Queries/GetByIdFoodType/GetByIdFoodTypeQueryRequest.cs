using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.FoodTypes.Queries.GetByIdFoodType
{
/// <summary>
/// GetByIdFoodTypeQueryRequest sınıfını temsil eder.
/// </summary>
public class GetByIdFoodTypeQueryRequest : IRequest<ResponseDto<GetByIdFoodTypeQueryResponse>>
    {
/// <summary>
/// GetByIdFoodTypeQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdFoodTypeQueryRequest(int id)
        {
            this.Id = id;
        }
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; }
    }
}
