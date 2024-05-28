using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.FoodTypes.Queries.GetByIdFoodType
{
    public class GetByIdFoodTypeQueryHandler : BaseHandler, IRequestHandler<GetByIdFoodTypeQueryRequest, Response<GetByIdFoodTypeQueryResponse>>
    {
        public GetByIdFoodTypeQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<GetByIdFoodTypeQueryResponse>> Handle(GetByIdFoodTypeQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<FoodType>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = mapper.Map<GetByIdFoodTypeQueryResponse, FoodType>(data);

            return new Response<GetByIdFoodTypeQueryResponse>().Success(map);
        }
    }
}
