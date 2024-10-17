using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Foods.Dto;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Entites.IntermediateTables;

namespace WorigoApp.Application.Features.Foods.Commands.CreateFood
{
    public class CreateFoodCommonHandler : BaseHandler, IRequestHandler<CreateFoodCommonRequest, Response<CreateFoodCommonResponse>>
    {
        public CreateFoodCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<CreateFoodCommonResponse>> Handle(CreateFoodCommonRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<FoodMenuCategory>().GetAsync(x => x.Id == request.FoodMenuCategoryId);

            var entityMap = mapper.Map<Food, CreateFoodCommonRequest>(request);

            var contentOfFoodRequestAndResponseMap = mapper.Map<ContentsOfFood, ContentOfFoodRequestAndResponseDto>(request.contentOfFoodRequestAndResponseDto);

            var greaterThanZeroList = contentOfFoodRequestAndResponseMap
                .Where(x => x.Id > 0)
                .ToList();

            // Id'si 0 olanları filtreleyen liste
            var equalToZeroList = contentOfFoodRequestAndResponseMap
                .Where(x => x.Id == 0)
                .ToList();


            unitOfWork.OpenTransaction();

            await unitOfWork.GetWriteRepository<ContentsOfFood>().AddRangeAsync(equalToZeroList);

            await unitOfWork.SaveAsync();

            var concatList = greaterThanZeroList.Concat(equalToZeroList);

            var saveEntity = await unitOfWork.GetWriteRepository<Food>().AddAsync(entityMap);

            await unitOfWork.SaveAsync();

            var foodContentsOfFoods = new List<FoodContentsOfFood>();

            foreach (var item in concatList)
            {
                foodContentsOfFoods.Add(new FoodContentsOfFood
                {
                    ContentsOfFoodId = item.Id,
                    FoodId = entityMap.Id,
                    IsActive = true
                });
            }

            await unitOfWork.GetWriteRepository<FoodContentsOfFood>().AddRangeAsync(foodContentsOfFoods);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new Response<CreateFoodCommonResponse>().Success();
        }
    }
}
