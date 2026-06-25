using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.FoodMenuCategories.Commands.UpdateFoodMenuCategory
{
/// <summary>
/// UpdateFoodMenuCategoryCommonHandler sınıfını temsil eder.
/// </summary>
public class UpdateFoodMenuCategoryCommonHandler : BaseHandler, IRequestHandler<UpdateFoodMenuCategoryCommonRequest, ResponseDto<UpdateFoodMenuCategoryCommonResponse>>
    {
/// <summary>
/// UpdateFoodMenuCategoryCommonHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public UpdateFoodMenuCategoryCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<UpdateFoodMenuCategoryCommonResponse>> Handle(UpdateFoodMenuCategoryCommonRequest request, CancellationToken cancellationToken)
        {
            var foodMenu = await unitOfWork.GetReadRepository<FoodMenuCategory>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            foodMenu.Name = request.Name;

            await unitOfWork.GetWriteRepository<FoodMenuCategory>().UpdateAsync(foodMenu);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new ResponseDto<UpdateFoodMenuCategoryCommonResponse>().Success();
        }
    }
}
