using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Foods.Queries.GetAllFoods
{
/// <summary>
/// GetAllFoodsQueryHandler sınıfını temsil eder.
/// </summary>
public class GetAllFoodsQueryHandler : BaseHandler, IRequestHandler<GetAllFoodsQueryRequest, ResponseDto<IList<GetAllFoodsQueryResponse>>>
    {
/// <summary>
/// GetAllFoodsQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetAllFoodsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<GetAllFoodsQueryResponse>>> Handle(GetAllFoodsQueryRequest request, CancellationToken cancellationToken)
        {
            var list = await unitOfWork.GetReadRepository<Food>().GetAllAsync(x => x.FoodMenuCategoryId == request.FoodMenuCategoryId);

            var map = mapper.Map<GetAllFoodsQueryResponse, Food>(list);

            return new ResponseDto<IList<GetAllFoodsQueryResponse>>().Success(map);    
        }
    }
}
