using MediatR;

namespace WorigoApp.Application.Features.FoodTypes.Queries.GetAllFoodTypes
{
/// <summary>
/// GetAllFoodTypesQueryRequest sınıfını temsil eder.
/// </summary>
public class GetAllFoodTypesQueryRequest : IRequest<IList<GetAllFoodTypesQueryResponse>>
    {
/// <summary>
/// GetAllFoodTypesQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetAllFoodTypesQueryRequest()
        {
            
        }
    }
}
