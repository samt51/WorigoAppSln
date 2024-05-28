using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Images.Queries.GetByIdImage
{
    public class GetByIdImageQueryHandler : BaseHandler, IRequestHandler<GetByIdImageQueryRequest, Response<GetByIdImageQueryResponse>>
    {
        public GetByIdImageQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<GetByIdImageQueryResponse>> Handle(GetByIdImageQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<Image>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = mapper.Map<GetByIdImageQueryResponse, Image>(data);

            return new Response<GetByIdImageQueryResponse>().Success(map);
        }
    }
}
