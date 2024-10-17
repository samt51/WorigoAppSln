using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ContentOfFoods.Queries.GetAllContent
{
    public class GetAllContentQueryHandler : BaseHandler, IRequestHandler<GetAllContentQueryRequest, Response<IList<GetAllContentQueryResponse>>>
    {
        public GetAllContentQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<IList<GetAllContentQueryResponse>>> Handle(GetAllContentQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<ContentsOfFood>().GetAllAsync(x => !x.IsDeleted);

            var map = mapper.Map<GetAllContentQueryResponse, ContentsOfFood>(data);

            return new Response<IList<GetAllContentQueryResponse>>().Success(map);
        }
    }
}
