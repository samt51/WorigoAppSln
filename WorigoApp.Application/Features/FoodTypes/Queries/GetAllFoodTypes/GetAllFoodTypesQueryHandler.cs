using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.FoodTypes.Queries.GetAllFoodTypes
{
/// <summary>
/// GetAllFoodTypesQueryHandler sınıfını temsil eder.
/// </summary>
public class GetAllFoodTypesQueryHandler : BaseHandler, IRequestHandler<GetAllFoodTypesQueryRequest, IList<GetAllFoodTypesQueryResponse>>
    {
/// <summary>
/// GetAllFoodTypesQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetAllFoodTypesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<IList<GetAllFoodTypesQueryResponse>> Handle(GetAllFoodTypesQueryRequest request, CancellationToken cancellationToken)
        {
            var list = await unitOfWork.GetReadRepository<FoodType>().GetAllAsync();

            return mapper.Map<GetAllFoodTypesQueryResponse, FoodType>(list);
        }
    }
}
