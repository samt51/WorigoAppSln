using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.FoodTypes.Queries.GetByIdFoodType
{
    public class GetByIdFoodTypeQueryRequest : IRequest<ResponseDto<GetByIdFoodTypeQueryResponse>>
    {
        public GetByIdFoodTypeQueryRequest(int id)
        {
            this.Id = id;
        }
        public int Id { get; }
    }
}
