using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Foods.Queries.GetAllFoods
{
    public class GetAllFoodsQueryHandler : BaseHandler, IRequestHandler<GetAllFoodsQueryRequest, IList<GetAllFoodsQueryResponse>>
    {
        public GetAllFoodsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<IList<GetAllFoodsQueryResponse>> Handle(GetAllFoodsQueryRequest request, CancellationToken cancellationToken)
        {
            var list = await unitOfWork.GetReadRepository<Food>().GetAllAsync(x => x.FoodMenuCategoryId == request.FoodMenuCategoryId);

            return mapper.Map<GetAllFoodsQueryResponse, Food>(list);
        }
    }
}
