using MediatR;

namespace WorigoApp.Application.Features.FoodTypes.Queries.GetAllFoodTypes
{
    public class GetAllFoodTypesQueryRequest : IRequest<IList<GetAllFoodTypesQueryResponse>>
    {
        public GetAllFoodTypesQueryRequest()
        {
            
        }
    }
}
