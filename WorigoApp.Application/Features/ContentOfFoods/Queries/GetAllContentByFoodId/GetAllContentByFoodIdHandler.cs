using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Entites.IntermediateTables;

namespace WorigoApp.Application.Features.ContentOfFoods.Queries.GetAllContentByFoodId
{
/// <summary>
/// GetAllContentByFoodIdHandler sınıfını temsil eder.
/// </summary>
public class GetAllContentByFoodIdHandler : BaseHandler, IRequestHandler<GetAllContentByFoodIdRequest, ResponseDto<IList<GetAllContentByFoodIdResponse>>>
    {
/// <summary>
/// GetAllContentByFoodIdHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetAllContentByFoodIdHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<GetAllContentByFoodIdResponse>>> Handle(GetAllContentByFoodIdRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<Food>().GetAsync(x => !x.IsDeleted && x.Id == request.FoodId);

            var data = await unitOfWork.GetReadRepository<FoodContentsOfFood>().GetAllAsync(x => x.FoodId == request.FoodId, include:
                y => y.Include(x => x.ContentsOfFood).ThenInclude(x => x.FoodContentsOfFoods));

            var result = data.Select(y => y.ContentsOfFood).ToList();

            var map = mapper.Map<GetAllContentByFoodIdResponse, ContentsOfFood>(result);

            return new ResponseDto<IList<GetAllContentByFoodIdResponse>>().Success(map);
        }
    }
}
