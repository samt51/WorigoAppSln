using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ServiceOfFeatures.Queries.GetAllServiceOfFeature
{
    public class GetAllServiceOfFeatureQueryHandler : BaseHandler, IRequestHandler<GetAllServiceOfFeatureQueryRequest, IList<GetAllServiceOfFeatureQueryResponse>>
    {
        public GetAllServiceOfFeatureQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<IList<GetAllServiceOfFeatureQueryResponse>> Handle(GetAllServiceOfFeatureQueryRequest request, CancellationToken cancellationToken)
        {
            var list = await unitOfWork.GetReadRepository<ServiceOfFeature>().GetAllAsync(X => X.ServiceId == request.ServiceId);

            return mapper.Map<GetAllServiceOfFeatureQueryResponse, ServiceOfFeature>(list);
        }
    }
}
