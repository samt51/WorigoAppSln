using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Foods.Queries.GetByFood
{
    public class GetByIdFoodQueryHandler : BaseHandler, IRequestHandler<GetByIdFoodQueryRequest, Response<GetByIdFoodQueryResponse>>
    {
        public GetByIdFoodQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<GetByIdFoodQueryResponse>> Handle(GetByIdFoodQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<Food>().GetAsync(x => x.Id == request.FoodId && !x.IsDeleted);

            var map = mapper.Map<GetByIdFoodQueryResponse, Food>(data);

            return new Response<GetByIdFoodQueryResponse>().Success(map);
        }
    }
}
