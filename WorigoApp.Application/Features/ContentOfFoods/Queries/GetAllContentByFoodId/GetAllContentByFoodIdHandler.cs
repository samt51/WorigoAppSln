using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Entites.IntermediateTables;

namespace WorigoApp.Application.Features.ContentOfFoods.Queries.GetAllContentByFoodId
{
    public class GetAllContentByFoodIdHandler : BaseHandler, IRequestHandler<GetAllContentByFoodIdRequest, Response<IList<GetAllContentByFoodIdResponse>>>
    {
        public GetAllContentByFoodIdHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<IList<GetAllContentByFoodIdResponse>>> Handle(GetAllContentByFoodIdRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<Food>().GetAsync(x => !x.IsDeleted && x.Id == request.FoodId);

            var data = await unitOfWork.GetReadRepository<FoodContentsOfFood>().GetAllAsync(x => x.FoodId == request.FoodId, include:
                y => y.Include(x => x.ContentsOfFood).ThenInclude(x => x.FoodContentsOfFoods));

            var result = data.Select(y => y.ContentsOfFood).ToList();

            var map = mapper.Map<GetAllContentByFoodIdResponse, ContentsOfFood>(result);

            return new Response<IList<GetAllContentByFoodIdResponse>>().Success(map);
        }
    }
}
