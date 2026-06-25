using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.FoodMenuCategories.Commands.CreateFoodMenuCategory
{
/// <summary>
/// CreateFoodMenuCategoryCommonHandler sınıfını temsil eder.
/// </summary>
public class CreateFoodMenuCategoryCommonHandler : BaseHandler, IRequestHandler<CreateFoodMenuCategoryCommonRequest, ResponseDto<CreateFoodMenuCategoryCommonResponse>>
    {
/// <summary>
/// CreateFoodMenuCategoryCommonHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateFoodMenuCategoryCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<CreateFoodMenuCategoryCommonResponse>> Handle(CreateFoodMenuCategoryCommonRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<Hotel>().GetAsync(x => x.Id == request.HotelId && !x.IsDeleted);

            var foodMenuMap = mapper.Map<FoodMenuCategory, CreateFoodMenuCategoryCommonRequest>(request);

            await unitOfWork.GetWriteRepository<FoodMenuCategory>().AddAsync(foodMenuMap);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new ResponseDto<CreateFoodMenuCategoryCommonResponse>().Success();
        }
    }
}
