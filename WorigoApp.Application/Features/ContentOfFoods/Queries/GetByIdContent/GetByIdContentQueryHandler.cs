using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ContentOfFoods.Queries.GetByIdContent
{
    public class GetByIdContentQueryHandler : BaseHandler, IRequestHandler<GetByIdContentQueryRequest, Response<GetByIdContentQueryResponse>>
    {
        public GetByIdContentQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<GetByIdContentQueryResponse>> Handle(GetByIdContentQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<ContentsOfFood>().GetAsync(x => !x.IsDeleted && x.Id == request.Id);

            var map = mapper.Map<GetByIdContentQueryResponse, ContentsOfFood>(data);

            return new Response<GetByIdContentQueryResponse>().Success(map);
        }
    }
}
