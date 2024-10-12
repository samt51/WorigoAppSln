using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ServiceOfFeatures.Queries.GetAllServiceOfFeature
{
    public class GetAllServiceOfFeatureQueryHandler : BaseHandler, IRequestHandler<GetAllServiceOfFeatureQueryRequest, Response<IList<GetAllServiceOfFeatureQueryResponse>>>
    {
        public GetAllServiceOfFeatureQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<IList<GetAllServiceOfFeatureQueryResponse>>> Handle(GetAllServiceOfFeatureQueryRequest request, CancellationToken cancellationToken)
        {
            var list = await unitOfWork.GetReadRepository<ServiceOfFeature>().GetAllAsync(X => X.ServiceId == request.ServiceId);

            var mapping = mapper.Map<GetAllServiceOfFeatureQueryResponse, ServiceOfFeature>(list);

            return new Response<IList<GetAllServiceOfFeatureQueryResponse>>().Success(mapping);
        }
    }
}
