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

            await unitOfWork.GetReadRepository<Hotel>().GetAsync(x => x.Id == request.HotelId && !x.IsDeleted);

            var foodMenuMap = mapper.Map<FoodMenuCategory, CreateFoodMenuCategoryCommonRequest>(request);

            await unitOfWork.GetWriteRepository<FoodMenuCategory>().AddAsync(foodMenuMap);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new Response<CreateFoodMenuCategoryCommonResponse>().Success();
        }
    }
}
