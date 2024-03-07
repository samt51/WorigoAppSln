using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.FoodMenuCategories.Commands.UpdateFoodMenuCategory
{
    public class UpdateFoodMenuCategoryCommonHandler : BaseHandler, IRequestHandler<UpdateFoodMenuCategoryCommonRequest, Response<UpdateFoodMenuCategoryCommonResponse>>
    {
        public UpdateFoodMenuCategoryCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<UpdateFoodMenuCategoryCommonResponse>> Handle(UpdateFoodMenuCategoryCommonRequest request, CancellationToken cancellationToken)
        {
            var foodMenu = await unitOfWork.GetReadRepository<FoodMenuCategory>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            if (foodMenu is null)
            {
                return new Response<UpdateFoodMenuCategoryCommonResponse>().Fail(new UpdateFoodMenuCategoryCommonResponse(), "Undifined", 400);
            }

            foodMenu.Name = request.Name;

            await unitOfWork.GetWriteRepository<FoodMenuCategory>().UpdateAsync(foodMenu);

            if (await unitOfWork.SaveAsync() > 0)
            {
                unitOfWork.Commit();
                return new Response<UpdateFoodMenuCategoryCommonResponse>().Success();
            }
            return new Response<UpdateFoodMenuCategoryCommonResponse>().Fail(new UpdateFoodMenuCategoryCommonResponse(), "", 400);
        }
    }
}
