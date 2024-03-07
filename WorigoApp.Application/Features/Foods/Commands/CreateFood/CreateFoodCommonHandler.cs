using MediatR;
using SendGrid;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Foods.Dto;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Foods.Commands.CreateFood
{
    public class CreateFoodCommonHandler : BaseHandler, IRequestHandler<CreateFoodCommonRequest, Response<CreateFoodCommonResponse>>
    {
        public CreateFoodCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<CreateFoodCommonResponse>> Handle(CreateFoodCommonRequest request, CancellationToken cancellationToken)
        {
            var foodMenuCategoryIsControll = await unitOfWork.GetReadRepository<FoodMenuCategory>().GetAsync(x => x.Id == request.FoodMenuCategoryId);

            if (foodMenuCategoryIsControll is null)
            {
                return new Response<CreateFoodCommonResponse>().Fail(new CreateFoodCommonResponse(), "Undifined", 400);
            }

            var entityMap = mapper.Map<Food, CreateFoodCommonRequest>(request);

            var contentOfFoodMap = mapper.Map<ContentsOfFood, ContentOfFoodRequestAndResponseDto>(request.contentOfFoodRequestAndResponseDto);

            var saveEntity = await unitOfWork.GetWriteRepository<Food>().AddAsync(entityMap);

            if (await unitOfWork.SaveAsync() > 0)
            {
                foreach (var item in contentOfFoodMap)
                {
                    item.FoodId = saveEntity.Id;
                }

                await unitOfWork.GetWriteRepository<ContentsOfFood>().AddRangeAsync(contentOfFoodMap);
                if (await unitOfWork.SaveAsync() > 0)
                {
                    unitOfWork.Commit();
                    return new Response<CreateFoodCommonResponse>().Success();
                }
            }

            return new Response<CreateFoodCommonResponse>().Fail(new CreateFoodCommonResponse(), "", 400);
        }
    }
}
