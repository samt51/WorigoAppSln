using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.FoodMenuCategories.Queries.GetAllFoodMenuCategories
{
    public class GetAllFoodMenuCategoriesQueryHandler : BaseHandler, IRequestHandler<GetAllFoodMenuCategoriesQueryRequest, IList<GetAllFoodMenuCategoriesQueryResponse>>
    {
        public GetAllFoodMenuCategoriesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<IList<GetAllFoodMenuCategoriesQueryResponse>> Handle(GetAllFoodMenuCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var list = await unitOfWork.GetReadRepository<FoodMenuCategory>().GetAllAsync(x => x.HotelId == request.HotelId);

            return mapper.Map<GetAllFoodMenuCategoriesQueryResponse, FoodMenuCategory>(list);
        }
    }
}
