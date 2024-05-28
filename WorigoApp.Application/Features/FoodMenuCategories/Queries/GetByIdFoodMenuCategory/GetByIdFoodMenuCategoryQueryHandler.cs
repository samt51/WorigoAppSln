using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Foods.Queries.GetAllFoods;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.FoodMenuCategories.Queries.GetByIdFoodMenuCategory
{
    public class GetByIdFoodMenuCategoryQueryHandler : BaseHandler, IRequestHandler<GetByIdFoodMenuCategoryQueryRequest, Response<GetByIdFoodMenuCategoryQueryResponse>>
    {
        public GetByIdFoodMenuCategoryQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<GetByIdFoodMenuCategoryQueryResponse>> Handle(GetByIdFoodMenuCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<FoodMenuCategory>().GetAsync(x => x.Id == request.FoodMenuCategoryId && !x.IsDeleted, y => y.Include(x => x.Foods));

            mapper.Map<GetAllFoodsQueryResponse, Food>(data.Foods);

            var mapData = mapper.Map<GetByIdFoodMenuCategoryQueryResponse, FoodMenuCategory>(data);

            return new Response<GetByIdFoodMenuCategoryQueryResponse>().Success(mapData);
        }
    }
}
