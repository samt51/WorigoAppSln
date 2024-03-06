using MediatR;

namespace WorigoApp.Application.Features.ServiceOfFeatures.Queries.GetAllServiceOfFeature
{
    public class GetAllServiceOfFeatureQueryRequest : IRequest<IList<GetAllServiceOfFeatureQueryResponse>>
    {
        public int ServiceId { get; set; }
        public GetAllServiceOfFeatureQueryRequest(int serviceId)
        {
            this.ServiceId = serviceId;
        }
    }
}
