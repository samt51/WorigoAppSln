using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ServiceOfValues.Queries.GetAllServiceOfValues
{
    public class GetAllServiceOfValuesQueryRequest : IRequest<Response<IList<GetAllServiceOfValuesQueryResponse>>>
    {
        public int? ServiceOfFeatureId { get;  }
        public int? ServiceId { get; set; }
        public GetAllServiceOfValuesQueryRequest(int? serviceOfFeature, int serviceId)
        {
            this.ServiceOfFeatureId = serviceOfFeature;
            this.ServiceId = serviceId;
        }
    }
}
