using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.UserFeature.Queries.GetByIdUser
{
    public class GetByIdUserQueryHandler : BaseHandler, IRequestHandler<GetByIdUserQueryRequest, Response<GetByIdUserQueryResponse>>
    {
        public GetByIdUserQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<GetByIdUserQueryResponse>> Handle(GetByIdUserQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<Users>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = mapper.Map<GetByIdUserQueryResponse, Users>(data);

            return new Response<GetByIdUserQueryResponse>().Success(map);
        }
    }
}
