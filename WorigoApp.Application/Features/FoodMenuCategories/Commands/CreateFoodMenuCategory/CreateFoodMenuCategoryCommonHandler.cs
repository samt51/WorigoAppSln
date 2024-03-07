using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.FoodMenuCategories.Commands.CreateFoodMenuCategory
{
    public class CreateFoodMenuCategoryCommonHandler : BaseHandler, IRequestHandler<CreateFoodMenuCategoryCommonRequest, Response<CreateFoodMenuCategoryCommonResponse>>
    {
        public CreateFoodMenuCategoryCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<CreateFoodMenuCategoryCommonResponse>> Handle(CreateFoodMenuCategoryCommonRequest request, CancellationToken cancellationToken)
        {
            var foodMenuMap = mapper.Map<FoodMenuCategory, CreateFoodMenuCategoryCommonRequest>(request);

            var hotelIsControll = await unitOfWork.GetReadRepository<Hotel>().GetAsync(x => x.Id == request.HotelId);

            if (hotelIsControll is null)
            {
                return new Response<CreateFoodMenuCategoryCommonResponse>().Fail(new CreateFoodMenuCategoryCommonResponse(), "Hotel Is Undifinied", 400);
            }

            var saveEntity = await unitOfWork.GetWriteRepository<FoodMenuCategory>().AddAsync(foodMenuMap);

            if (await unitOfWork.SaveAsync() > 0)
            {
                unitOfWork.Commit();
                return new Response<CreateFoodMenuCategoryCommonResponse>().Success();
            }
            return new Response<CreateFoodMenuCategoryCommonResponse>().Fail(new CreateFoodMenuCategoryCommonResponse(), "", 400);
        }
    }
}
