using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.FoodMenuCategories.Queries.GetAllFoodMenuCategories
{
/// <summary>
/// GetAllFoodMenuCategoriesQueryHandler sınıfını temsil eder.
/// </summary>
public class GetAllFoodMenuCategoriesQueryHandler : BaseHandler, IRequestHandler<GetAllFoodMenuCategoriesQueryRequest, ResponseDto<IList<GetAllFoodMenuCategoriesQueryResponse>>>
    {
/// <summary>
/// GetAllFoodMenuCategoriesQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetAllFoodMenuCategoriesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<GetAllFoodMenuCategoriesQueryResponse>>> Handle(GetAllFoodMenuCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var list = await unitOfWork.GetReadRepository<FoodMenuCategory>().GetAllAsync(x => x.HotelId == request.HotelId);

            var map = mapper.Map<GetAllFoodMenuCategoriesQueryResponse, FoodMenuCategory>(list);

            return new ResponseDto<IList<GetAllFoodMenuCategoriesQueryResponse>>().Success(map);
        }
    }
}
