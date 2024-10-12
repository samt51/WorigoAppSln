using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.FoodTypes.Queries.GetAllFoodTypes
{
    public class GetAllFoodTypesQueryHandler : BaseHandler, IRequestHandler<GetAllFoodTypesQueryRequest, Response<IList<GetAllFoodTypesQueryResponse>>>
    {
        public GetAllFoodTypesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<IList<GetAllFoodTypesQueryResponse>>> Handle(GetAllFoodTypesQueryRequest request, CancellationToken cancellationToken)
        {
            var list = await unitOfWork.GetReadRepository<FoodType>().GetAllAsync();

            var mapping = mapper.Map<GetAllFoodTypesQueryResponse, FoodType>(list);

            return new Response<IList<GetAllFoodTypesQueryResponse>>().Success(mapping);
        }
    }
}
