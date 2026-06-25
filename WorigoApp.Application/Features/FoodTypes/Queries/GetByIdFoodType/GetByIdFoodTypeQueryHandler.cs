using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.FoodTypes.Queries.GetByIdFoodType
{
/// <summary>
/// GetByIdFoodTypeQueryHandler sınıfını temsil eder.
/// </summary>
public class GetByIdFoodTypeQueryHandler : BaseHandler, IRequestHandler<GetByIdFoodTypeQueryRequest, ResponseDto<GetByIdFoodTypeQueryResponse>>
    {
/// <summary>
/// GetByIdFoodTypeQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdFoodTypeQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<GetByIdFoodTypeQueryResponse>> Handle(GetByIdFoodTypeQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<FoodType>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = mapper.Map<GetByIdFoodTypeQueryResponse, FoodType>(data);

            return new ResponseDto<GetByIdFoodTypeQueryResponse>().Success(map);
        }
    }
}
