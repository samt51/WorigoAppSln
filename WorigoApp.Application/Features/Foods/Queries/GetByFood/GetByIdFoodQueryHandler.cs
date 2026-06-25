using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Foods.Queries.GetByFood
{
/// <summary>
/// GetByIdFoodQueryHandler sınıfını temsil eder.
/// </summary>
public class GetByIdFoodQueryHandler : BaseHandler, IRequestHandler<GetByIdFoodQueryRequest, ResponseDto<GetByIdFoodQueryResponse>>
    {
/// <summary>
/// GetByIdFoodQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdFoodQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<GetByIdFoodQueryResponse>> Handle(GetByIdFoodQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<Food>().GetAsync(x => x.Id == request.FoodId && !x.IsDeleted);

            var map = mapper.Map<GetByIdFoodQueryResponse, Food>(data);

            return new ResponseDto<GetByIdFoodQueryResponse>().Success(map);
        }
    }
}
