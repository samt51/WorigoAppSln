using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ServiceOfValues.Queries.GetAllServiceOfValues
{
    public class GetAllServiceOfValuesQueryHandler : BaseHandler, IRequestHandler<GetAllServiceOfValuesQueryRequest, IList<GetAllServiceOfValuesQueryResponse>>
    {
        public GetAllServiceOfValuesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<IList<GetAllServiceOfValuesQueryResponse>> Handle(GetAllServiceOfValuesQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<ServiceOfValue>().GetAllAsync(x => x.ServiceOfFeatureId == request.ServiceOfFeatureId);

            var maplist = mapper.Map<GetAllServiceOfValuesQueryResponse, ServiceOfValue>(data);

            if (maplist.Count == 0)
            {
                var value = await unitOfWork.GetReadRepository<ServiceOfValue>().GetAllAsync(x => x.ServiceId == request.ServiceId);

                var dataMap = mapper.Map<GetAllServiceOfValuesQueryResponse, ServiceOfValue>(value);
                return dataMap;
            }
            return maplist;
        }
    }
}
