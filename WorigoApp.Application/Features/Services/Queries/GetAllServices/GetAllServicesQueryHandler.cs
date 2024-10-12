using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Services.Queries.GetAllServices
{
    public class GetAllServicesQueryHandler : BaseHandler, IRequestHandler<GetAllServicesQueryRequest, Response<IList<GetAllServicesQueryResponse>>>
    {
        public GetAllServicesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<IList<GetAllServicesQueryResponse>>> Handle(GetAllServicesQueryRequest request, CancellationToken cancellationToken)
        {
            var list = await unitOfWork.GetReadRepository<Service>().GetAllAsync(x => x.HotelId == request.HotelId);

            var mapping = mapper.Map<GetAllServicesQueryResponse, Service>(list);

            return new Response<IList<GetAllServicesQueryResponse>>().Success(mapping);
        }
    }
}
