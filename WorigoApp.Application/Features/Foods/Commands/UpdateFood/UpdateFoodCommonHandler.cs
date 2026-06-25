using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Foods.Dto;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Foods.Commands.UpdateFood
{
/// <summary>
/// UpdateFoodCommonHandler sınıfını temsil eder.
/// </summary>
public class UpdateFoodCommonHandler : BaseHandler, IRequestHandler<UpdateFoodCommonRequest, ResponseDto<UpdateFoodCommonResponse>>
    {
/// <summary>
/// UpdateFoodCommonHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public UpdateFoodCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<UpdateFoodCommonResponse>> Handle(UpdateFoodCommonRequest request, CancellationToken cancellationToken)
        {
            var foodMenuCategoryIsControll = await unitOfWork.GetReadRepository<FoodMenuCategory>().GetAsync(x => x.Id == request.FoodMenuCategoryId && !x.IsDeleted);


            var entityMap = mapper.Map<Food, UpdateFoodCommonRequest>(request);

            var contentOfFoodMap = mapper.Map<ContentsOfFood, ContentOfFoodRequestAndResponseDto>(request.contentOfFoodRequestAndResponseDto);

            await unitOfWork.GetWriteRepository<Food>().UpdateAsync(entityMap);

            await unitOfWork.GetWriteRepository<ContentsOfFood>().AddRangeAsync(contentOfFoodMap);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new ResponseDto<UpdateFoodCommonResponse>().Success();
        }
    }
}


