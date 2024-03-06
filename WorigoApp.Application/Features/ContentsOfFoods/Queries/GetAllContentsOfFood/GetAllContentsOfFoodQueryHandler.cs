using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ContentsOfFoods.Queries.GetAllContentsOfFood
{
    public class GetAllContentsOfFoodQueryHandler : BaseHandler, IRequestHandler<GetAllContentsOfFoodQueryRequest, IList<GetAllContentsOfFoodQueryResponse>>
    {
        public GetAllContentsOfFoodQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<IList<GetAllContentsOfFoodQueryResponse>> Handle(GetAllContentsOfFoodQueryRequest request, CancellationToken cancellationToken)
        {
            var listData = await unitOfWork.GetReadRepository<ContentsOfFood>().GetAllAsync(x => x.FoodId == request.FoodId);

            return mapper.Map<GetAllContentsOfFoodQueryResponse, ContentsOfFood>(listData);
        }
    }
}
