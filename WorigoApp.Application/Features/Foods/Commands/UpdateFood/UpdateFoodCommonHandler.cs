using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Foods.Dto;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Foods.Commands.UpdateFood
{
    public class UpdateFoodCommonHandler : BaseHandler, IRequestHandler<UpdateFoodCommonRequest, Response<UpdateFoodCommonResponse>>
    {
        public UpdateFoodCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<UpdateFoodCommonResponse>> Handle(UpdateFoodCommonRequest request, CancellationToken cancellationToken)
        {
            var foodMenuCategoryIsControll = await unitOfWork.GetReadRepository<FoodMenuCategory>().GetAsync(x => x.Id == request.FoodMenuCategoryId && !x.IsDeleted);


            var entityMap = mapper.Map<Food, UpdateFoodCommonRequest>(request);

            var contentOfFoodMap = mapper.Map<ContentsOfFood, ContentOfFoodRequestAndResponseDto>(request.contentOfFoodRequestAndResponseDto);

            await unitOfWork.GetWriteRepository<Food>().UpdateAsync(entityMap);

            await unitOfWork.GetWriteRepository<ContentsOfFood>().AddRangeAsync(contentOfFoodMap);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new Response<UpdateFoodCommonResponse>().Success();
        }
    }
}


