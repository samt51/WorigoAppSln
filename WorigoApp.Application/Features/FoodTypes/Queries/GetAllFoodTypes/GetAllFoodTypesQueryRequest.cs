using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.FoodTypes.Queries.GetAllFoodTypes
{
    public class GetAllFoodTypesQueryRequest : IRequest<Response<IList<GetAllFoodTypesQueryResponse>>>
    {
        public GetAllFoodTypesQueryRequest()
        {
            
        }
    }
}
