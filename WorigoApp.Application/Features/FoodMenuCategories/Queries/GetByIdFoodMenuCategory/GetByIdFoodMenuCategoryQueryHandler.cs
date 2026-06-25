using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Foods.Queries.GetAllFoods;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.FoodMenuCategories.Queries.GetByIdFoodMenuCategory
{
/// <summary>
/// GetByIdFoodMenuCategoryQueryHandler sınıfını temsil eder.
/// </summary>
public class GetByIdFoodMenuCategoryQueryHandler : BaseHandler, IRequestHandler<GetByIdFoodMenuCategoryQueryRequest, ResponseDto<GetByIdFoodMenuCategoryQueryResponse>>
    {
/// <summary>
/// GetByIdFoodMenuCategoryQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdFoodMenuCategoryQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<GetByIdFoodMenuCategoryQueryResponse>> Handle(GetByIdFoodMenuCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<FoodMenuCategory>().GetAsync(x => x.Id == request.FoodMenuCategoryId && !x.IsDeleted, y => y.Include(x => x.Foods));

            mapper.Map<GetAllFoodsQueryResponse, Food>(data.Foods);

            var mapData = mapper.Map<GetByIdFoodMenuCategoryQueryResponse, FoodMenuCategory>(data);

            return new ResponseDto<GetByIdFoodMenuCategoryQueryResponse>().Success(mapData);
        }
    }
}
